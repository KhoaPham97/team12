// function to add new Bucket to one Plan
// method: GET
// params: 

module.exports = async function (context, req) {
    context.log('JavaScript HTTP trigger function processed a request.');

    var my_module = require('../node_modules/capstone')

    var title = req.body.title;
    var description = req.body.description;
    var startdate = req.body.startdate;
    var duedate = req.body.duedate;
    var planid = req.body.planid;
    var assigneeid = req.body.assigneeid;
    var reporterid = req.body.reporterid;
    var status_value = req.body.status;
    var assigneename = req.body.assigneename;
    var reportername = req.body.reportername;

    context.log("title : " + title)
    context.log("description : " + description )
    context.log("startdate : " + startdate)
    context.log("duedate : " + duedate)
    context.log("planid : " + planid)
    context.log("assigneeid : " + assigneeid)
    context.log("reporterid : " + reporterid)
    context.log("status_value : " + status_value)
    context.log("assigneename : " + assigneename)
    context.log("reportername : " + reportername)

    if (!(title && description && startdate && duedate && planid && assigneeid && reporterid && status_value && reportername && assigneename)) {
        context.res = {
            status: 400,
            body: "Missing parameters"
        };
        context.done()
    }
    else {
        let result = await my_module.createNewBucket(planid, assigneeid, assigneename, reporterid, reportername, title, description, status_value, startdate, duedate)
        context.res = {
            status: 200,
            body: {"Buckets ID" : '' + result}
        };
        context.done()
        
    }
};