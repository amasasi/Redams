using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Redams.Common.Model
{
  public  class FormElementFactory
    {

        private  int ExcelHandle = 1;
        IWorkbook workbook = null;

        private  List<Field> CreateElements( IWorksheet worksheet)
        {

            var elements = new List<Field>();
            while (ExcelHandle < worksheet.Rows.Length)
            {



                var formelement = new Field();
                formelement.ID = Guid.NewGuid().ToString();
                var control_type = worksheet.Rows[ExcelHandle].Cells[0].Value2.ToString();
                if (control_type.StartsWith("select_one"))
                {

                    formelement.Type = "select_one";
                    var choiceName = control_type.Substring("select_one".Length).Trim();
                    var choice_sheet = this.workbook.Worksheets["choices"];

                    var C = 1;
                    while (C < choice_sheet.Rows.Length)
                    {
                        if (choice_sheet.Rows[C].Cells[0].Value.ToString() == choiceName)
                            formelement.Options.Add(new Option { Value = choice_sheet.Rows[C].Cells[1].Value.ToString(), Label = choice_sheet.Rows[C].Cells[2].Value.ToString() });

                        C = C + 1;
                    }

                }
                else
                    formelement.Type = control_type;
                





                if (formelement.Type == "end_group")
                {
                    ExcelHandle = ExcelHandle + 1;
                    return elements;
                }
                formelement.Name = worksheet.Rows[ExcelHandle].Cells[1].Value2.ToString();
                formelement.Label = worksheet.Rows[ExcelHandle].Cells[2].Value2.ToString();
                elements.Add(formelement);
                ExcelHandle = ExcelHandle + 1;
                if (formelement.Type == "begin_group"  || formelement.Type == "begin group" || formelement.Type == "begin_repeat" || formelement.Type == "begin repeat")
                {
                    formelement.Type = "Group";
                    if (formelement.Type == "begin_repeat" || formelement.Type == "begin repeat")
                        formelement.Type = "Repeat";
                    foreach (var t in CreateElements(worksheet))
                    {
                        //t.ParentField = formelement;

                        //formelement.FormElements.Add(t);
                    }
                        
                }


                



              
            }

         
            return elements;
        }


        public Project Create2(byte[] file)
        {
            return Create(file);
        }
            public  Project Create(byte[] file)
        {

            var proj= new Project {ID =Guid.NewGuid().ToString() };
            var form = new Form { };
            proj.Forms.Add(form);
            using (var mem=new System.IO.MemoryStream(file))
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
               
                //Instantiate the Excel application object
                IApplication application = excelEngine.Excel;

                application.Workbooks.Open(mem);
                //Assigns default application version
                application.DefaultVersion = ExcelVersion.Excel2016;
                application.UseFastRecordParsing = true;
               
                //A new workbook is created equivalent to creating a new workbook in Excel
                //Create a workbook with 1 worksheet
                workbook = application.Workbooks[0];

                
                //Access first worksheet from the workbook
                IWorksheet worksheet = workbook.Worksheets[0];
               
                ExcelHandle = 1;

                foreach (var el in CreateElements(worksheet))
                {

                    el.Form = form;
                    form.Fields.Add(el);
                }

               form.Fields .Add(new Field { ID = Guid.NewGuid().ToString(), Type = "end form", Form = form });

                //Adding text to a cell
                worksheet.Range["A1"].Text = "Hello World";

                //Saving the workbook to disk in XLSX format
               // workbook.SaveAs("Sample.xlsx");
            }

            return proj;


        }
    }
}
