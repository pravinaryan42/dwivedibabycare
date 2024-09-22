using RKD.Data;
using RKD.DataTable.Extension;
using RKD.DataTable.Search;
using RKD.DataTable.Sort;
using RKD.Service;
using RKD.Web.Code.Attributes;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor.Parser.SyntaxTree;
using RKD.Web.Areas.Admin.Models;
using RKD.Core;
using RKD.Web.Code.LIBS;
using System.IO;
using System.Web.Routing;
using OfficeOpenXml;
using System.Threading.Tasks;
using RKD.DTO;

namespace RKD.Web.Controllers
{
    [CustomAuthorization]
    public class GeoRecordController : BaseController
    {
        //private readonly IRecordService recordService;

        public GeoRecordController(/*IRecordService recordService*/)
        {
            //this.recordService = recordService;
        }
        // GET: GeoRecord
        public ActionResult Index()
        {
            SelectionModel model=new SelectionModel();
            //List<SelectListItem> lstmodel = new List<SelectListItem>();
            //lstmodel = recordService.GetAllBlocks();
            //if (lstmodel!=null && lstmodel.Count > 0) {
            //    foreach (string text in lstmodel.Select(x => x.Text).Distinct()) {
            //        model.BlockDataList.Add(new SelectListItem { Text = text, Value = text });
            //    }
            //    model.BlockDataList = model.BlockDataList.OrderBy(x => x.Text).ToList();
            //}
            return View(model);
        }


        /// <summary>
        /// Get Location
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(DataTable.DataTables.DataTable dataTable,string SelectedBlock)
        {
            List<DataTableRow> table = new List<DataTableRow>();
            //List<int> column1 = new List<int>();
            //for (int i = dataTable.iDisplayStart; i < dataTable.iDisplayStart + dataTable.iDisplayLength; i++)
            //{
            //    column1.Add(i);
            //}
            //var query = new SearchQuery<GeoRecord>();
            //if (!string.IsNullOrEmpty(dataTable.sSearch))
            //{
            //    string sSearch = dataTable.sSearch.ToLower();
            //    query.AddFilter(q => (q.CONSUMERNAME.Contains(sSearch)) || (q.PROPERTYTYPE.Contains(sSearch)) || (q.STATUS.Contains(sSearch)));
            //}
            //if (!string.IsNullOrEmpty(SelectedBlock) && SelectedBlock != "All") {
            //    query.AddFilter(q => q.BLOCK == SelectedBlock);
            //}
            //var sortColumnIndex = Convert.ToInt32(Request["iSortCol_0"]);
            //var sortDirection = Request["sSortDir_0"];
            //switch (sortColumnIndex)
            //{
            //    case 2:
            //        query.AddSortCriteria(new ExpressionSortCriteria<GeoRecord, string>(q => q.DISTRICT, sortDirection == "asc" ? SortDirection.Ascending : SortDirection.Descending));
            //        break;
            //    case 3:
            //        query.AddSortCriteria(new ExpressionSortCriteria<GeoRecord, string>(q => q.BLOCK, sortDirection == "asc" ? SortDirection.Ascending : SortDirection.Descending));
            //        break;

            //    case 4:
            //        query.AddSortCriteria(new ExpressionSortCriteria<GeoRecord, string>(q => q.GP, sortDirection == "asc" ? SortDirection.Ascending : SortDirection.Descending));
            //        break;

            //    case 6:
            //        query.AddSortCriteria(new ExpressionSortCriteria<GeoRecord, string>(q => q.VILLAGE, sortDirection == "asc" ? SortDirection.Ascending : SortDirection.Descending));
            //        break;

            //    case 7:
            //        query.AddSortCriteria(new ExpressionSortCriteria<GeoRecord, string>(q => q.HABITATION, sortDirection == "asc" ? SortDirection.Ascending : SortDirection.Descending));
            //        break;
            //    case 8:
            //        query.AddSortCriteria(new ExpressionSortCriteria<GeoRecord, string>(q => q.LATITUDE, sortDirection == "asc" ? SortDirection.Ascending : SortDirection.Descending));
            //        break;
            //    case 9:
            //        query.AddSortCriteria(new ExpressionSortCriteria<GeoRecord, string>(q => q.LONGITUDE, sortDirection == "asc" ? SortDirection.Ascending : SortDirection.Descending));
            //        break;

            //    case 10:
            //        query.AddSortCriteria(new ExpressionSortCriteria<GeoRecord, string>(q => q.PROPERTYID, sortDirection == "asc" ? SortDirection.Ascending : SortDirection.Descending));
            //        break;
            //    case 11:
            //        query.AddSortCriteria(new ExpressionSortCriteria<GeoRecord, string>(q => q.PROPERTYTYPE, sortDirection == "asc" ? SortDirection.Ascending : SortDirection.Descending));
            //        break;
            //    case 12:
            //        query.AddSortCriteria(new ExpressionSortCriteria<GeoRecord, int?>(q => q.NUMBE_ROF_FLOORS, sortDirection == "asc" ? SortDirection.Ascending : SortDirection.Descending));
            //        break;

            //    case 13:
            //        query.AddSortCriteria(new ExpressionSortCriteria<GeoRecord, string>(q => q.CONSTRUCTIONTYPE, sortDirection == "asc" ? SortDirection.Ascending : SortDirection.Descending));
            //        break;
            //    case 14:
            //        query.AddSortCriteria(new ExpressionSortCriteria<GeoRecord, string>(q => q.CONSUMERNAME, sortDirection == "asc" ? SortDirection.Ascending : SortDirection.Descending));
            //        break;
            //    case 15:
            //        query.AddSortCriteria(new ExpressionSortCriteria<GeoRecord, string>(q => q.PHONENO, sortDirection == "asc" ? SortDirection.Ascending : SortDirection.Descending));
            //        break;

            //    case 16:
            //        query.AddSortCriteria(new ExpressionSortCriteria<GeoRecord, int?>(q => q.FAMILYCOUNT, sortDirection == "asc" ? SortDirection.Ascending : SortDirection.Descending));
            //        break;
            //    case 17:
            //        query.AddSortCriteria(new ExpressionSortCriteria<GeoRecord, string>(q => q.WATERSUPPLYTYPE, sortDirection == "asc" ? SortDirection.Ascending : SortDirection.Descending));
            //        break;
            //    case 18:
            //        query.AddSortCriteria(new ExpressionSortCriteria<GeoRecord, decimal?>(q => q.SUPPLY_IN_HOURS, sortDirection == "asc" ? SortDirection.Ascending : SortDirection.Descending));
            //        break;
            //    case 19:
            //        query.AddSortCriteria(new ExpressionSortCriteria<GeoRecord, int?>(q => q.NUMBER_OF_CONNECTIONS, sortDirection == "asc" ? SortDirection.Ascending : SortDirection.Descending));
            //        break;
            //    case 20:
            //        query.AddSortCriteria(new ExpressionSortCriteria<GeoRecord, string>(q => q.REMARKS, sortDirection == "asc" ? SortDirection.Ascending : SortDirection.Descending));
            //        break;
            //    case 21:
            //        query.AddSortCriteria(new ExpressionSortCriteria<GeoRecord, string>(q => q.STATUS, sortDirection == "asc" ? SortDirection.Ascending : SortDirection.Descending));
            //        break;
            //    default:
            //        query.AddSortCriteria(new ExpressionSortCriteria<GeoRecord, DateTime?>(q => q.UPLOADEDON, SortDirection.Descending));
            //        break;
            //}
            //query.Take = dataTable.iDisplayLength;
            //query.Skip = dataTable.iDisplayStart;

            //int count = dataTable.iDisplayStart + 1, total = 0;

            //IEnumerable<GeoRecord> records = recordService.GetGeoRecord(query, out total).Entities;
            //foreach (var item in records)
            //{
            //    table.Add(new DataTableRow("rowId" + count.ToString(), "dtrowclass")
            //    {
            //        item.FID.ToString(),//0
            //        count.ToString(),//1             
            //        item.DISTRICT,
            //        item.BLOCK,
            //        item.GP,
            //        item.VILLAGE,
            //        item.HABITATION,
            //        item.LATITUDE,
            //        item.LONGITUDE,
            //        item.PROPERTYID,
            //        item.PROPERTYTYPE,
            //        Convert.ToString(item.NUMBE_ROF_FLOORS),
            //        item.CONSTRUCTIONTYPE,
            //        item.CONSUMERNAME,
            //        item.PHONENO,
            //        Convert.ToString(item.FAMILYCOUNT),
            //        Convert.ToString(item.WATERSUPPLYTYPE),
            //        Convert.ToString(item.SUPPLY_IN_HOURS),
            //        Convert.ToString(item.NUMBER_OF_CONNECTIONS),
            //        item.REMARKS,
            //        item.STATUS,
            //        item.SURVEYOR_LOCATION,
            //        item.USERNAME,
            //        item.CONNECTIONSTATUS,
            //        item.CONNECTIONPHOTO,//4,         
            //        Convert.ToString(item.NumberOfRoom),
            //    });
            //    count++;
            //}
            return new DataTableResultExt(dataTable, table.Count, 0, table);
        }

        [HttpGet]
        public PartialViewResult ImportRecord()
        {
            ImportFileModel model = new ImportFileModel();
            return PartialView("ImportRecord", model);
        }
        private string test(System.Data.DataTable dt, string path)
        {

            string csv = string.Empty, resultPath = string.Empty;

            foreach (DataColumn column in dt.Columns)
            {
                //Add the Header row for CSV file.
                csv += column.ColumnName + '\t';
            }

            //Add new line.
            csv += "\r\n";

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    //Add the Data rows.
                    csv += row[column.ColumnName].ToString().Replace(",", ";") + '\t';
                }

                //Add new line.
                csv += "\r\n";
            }
            resultPath = path + ".xls";
            string filepath = Server.MapPath(resultPath);
            System.IO.File.WriteAllText(filepath, csv);
            return resultPath;
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ImportRecordData(ImportFileModel model)
        {
           
            //int count = 0;
            //int insertedcount = 0;
            //string resultPath = string.Empty;

            //if (model != null && model.ImportedFile != null && model.ImportedFile.ContentLength > 0)
            //{
            //    var fileExtension = Path.GetExtension(model.ImportedFile.FileName);

            //    try
            //    {
            //        var fileName = DateTime.Now.Ticks;
            //        string filePathtoSave = SiteKeys.ImportedFilePath + string.Format("Results/Record{0}", DateTime.Now.Ticks);
            //        string path = Server.MapPath(string.Format(filePathtoSave + "{0}", fileExtension));
            //        model.ImportedFile.SaveAs(path);
            //        DataSet ds = new DataSet();
            //        if (fileExtension == ".csv" || fileExtension == ".CSV")
            //        {
            //            ds = ImportData.ConvertCsvToDataSet(model.ImportedFile.InputStream);
            //        }
            //        else
            //        {
            //            ds = ImportData.ConvertExcelToDataSet(model.ImportedFile.InputStream);
            //        }

            //        List<GeoRecord> records = new List<GeoRecord>();
            //        if (ds != null && ds.Tables.Count > 0)
            //        {
            //            System.Data.DataTable dtAllergy = ds.Tables[0];
            //            count = dtAllergy != null ? dtAllergy.Rows.Count : 0;
            //            IQueryable<GeoRecord> allergiesList = recordService.GetGeoRecords().AsQueryable();
            //            bool isSuccess = true;
            //            foreach (DataRow r in dtAllergy.Rows)
            //            {

            //                GeoRecord importedrecord = new GeoRecord();
            //                string fid = Convert.ToString(r["FID"]);
            //                importedrecord.FID = Convert.ToInt64(fid ?? "0");
            //                importedrecord.DISTRICT = Convert.ToString(r["DISTRICT"]);
            //                importedrecord.BLOCK = Convert.ToString(r["BLOCK"]);
            //                importedrecord.GP = Convert.ToString(r["GP"]);
            //                importedrecord.VILLAGE = Convert.ToString(r["VILLAGE"]);
            //                importedrecord.HABITATION = Convert.ToString(r["HABITATION"]);
            //                importedrecord.LATITUDE = Convert.ToString(r["LATITUDE"]);
            //                importedrecord.LONGITUDE = Convert.ToString(r["LONGITUDE"]);
            //                importedrecord.PROPERTYID = Convert.ToString(r["PROPERTYID"]);
            //                importedrecord.PROPERTYTYPE = Convert.ToString(r["PROPERTYTYPE"]);
            //                importedrecord.NUMBE_ROF_FLOORS = Convert.ToInt32(r["NUMBER_OF_FLOORS"] ?? "0");
            //                importedrecord.CONSTRUCTIONTYPE = Convert.ToString(r["CONSTRUCTIONTYPE"]);
            //                importedrecord.CONSUMERNAME = Convert.ToString(r["CONSUMERNAME"]);
            //                importedrecord.PHONENO = Convert.ToString(r["PHONENO"]);
            //                importedrecord.FAMILYCOUNT = Convert.ToInt32(r["FAMILYCOUNT"]);
            //                importedrecord.WATERSUPPLYTYPE = (Convert.ToString(r["WATERSUPPLYTYPE"]) ?? "0");
            //                string supp = Convert.ToString(r["SUPPLY_IN_HOURS"]);
            //                importedrecord.SUPPLY_IN_HOURS = Convert.ToDecimal(!string.IsNullOrEmpty(supp) ? supp : "0");
            //                string suppConnection = Convert.ToString(r["NUMBER_OF_CONNECTIONS"]);
            //                importedrecord.NUMBER_OF_CONNECTIONS = Convert.ToInt32(!string.IsNullOrEmpty(suppConnection) ? suppConnection : "0");
            //                importedrecord.REMARKS = Convert.ToString(r["REMARKS"]);
            //                importedrecord.STATUS = Convert.ToString(r["STATUS"]);
            //                importedrecord.SURVEYOR_LOCATION = Convert.ToString(r["SURVEYOR_LOCATION"]);
            //                importedrecord.USERNAME = Convert.ToString(r["USERNAME"]);
            //                importedrecord.CONNECTIONSTATUS = Convert.ToString(r["CONNECTIONSTATUS"]);
            //                importedrecord.CONNECTIONPHOTO = Convert.ToString(r["CONNECTIONPHOTO"]);
            //                string NumberOfRoom = Convert.ToString(r["NUMBEROFROOM"]);
            //                importedrecord.NumberOfRoom = Convert.ToInt32(!string.IsNullOrEmpty(NumberOfRoom) ? NumberOfRoom:"0");
            //                importedrecord.UPLOADEDBY = CurrentUser.UserId;
            //                importedrecord.UPLOADEDON = DateTime.Now;
            //                if (!(allergiesList.Any(x => !string.IsNullOrEmpty(importedrecord.PROPERTYID) && x.PROPERTYTYPE == importedrecord.PROPERTYTYPE)))
            //                {
            //                    if (!string.IsNullOrWhiteSpace(importedrecord.PROPERTYID))
            //                    {
            //                        records.Add(importedrecord);
            //                        r["Result"] = "Sucess";
            //                    }
            //                    else
            //                    {
            //                        r["Reason"] = "Allergy name is null";
            //                        isSuccess = false;
            //                    }

            //                }
            //                else
            //                {
            //                    r["Reason"] = "Allergy name already exists";
            //                    isSuccess = false;
            //                }


            //            }
            //            if (!isSuccess)
            //            {
            //                resultPath = test(ds.Tables[0], filePathtoSave);
            //            }
            //        }
            //        insertedcount = records != null ? records.Count : 0;
            //        recordService.SaveCollection(records);

            //    }
            //    catch (Exception ex)
            //    {
            //        ShowErrorMessage("Fail", ex.Message, false);
            //        return NewtonSoftJsonResult(new RequestOutcome<string> { RedirectUrl = @Url.Action("Index", "GeoRecord") });
            //    }

            //}
            //ShowSuccessMessage("Success", string.Format("Total {0} records(s) are imported successfully out of {1}.", insertedcount, count), false);

            return NewtonSoftJsonResult(new RequestOutcome<string> { Message = "", RedirectUrl = @Url.Action("Index", "GeoRecord") });

        }

        private Dictionary<string, int> GetColumnNames(ExcelWorksheet worksheet)
        {
            var columnNames = new Dictionary<string, int>();
            var headerRow = worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column];

            foreach (var cell in headerRow)
            {
                columnNames[cell.Text] = cell.Start.Column;
            }

            return columnNames;
        }

        private int GetColumnIndex(Dictionary<string, int> columnNames, string columnName)
        {
            return columnNames.TryGetValue(columnName, out var columnIndex) ? columnIndex : -1;
        }
        public FileResult Download()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath(SiteKeys.TemplateFilePath + "SampleDataImport.xlsx"));
            string fileName = "SampleDataImport.Xlsx";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

    }
}