module.exports = async function (context, req) {
    context.log('JavaScript HTTP trigger function processed a request.');

    var my_module = require('../node_modules/capstone')

    var title = req.body.title;
    var description = req.body.description;
    var startdate = req.body.startdate;
    var duedate = req.body.duedate;
    var planid = req.body.planid;
    var bucketid = req.body.bucketid;
    var assigneeid = req.body.assigneeid;
    var assigneename = req.body.assigneename;
    var reporterid = req.body.reporterid;
    var reportername = req.body.reportername;
    var status_value = req.body.status;

    context.log("title : " + title)
    context.log("description : " + description )
    context.log("startdate : " + startdate)
    context.log("duedate : " + duedate)
    context.log("planid : " + planid)
    context.log("bucketid :  " + bucketid)
    context.log("assigneeid : " + assigneeid)
    context.log("reporterid : " + reporterid)
    context.log("status_value : " + status_value)
    context.log("assigneename : " + assigneename)
    context.log("reportername : " + reportername)


    if (!(title && description && startdate && duedate && planid && assigneeid && reporterid && status_value && bucketid)) {
        context.res = {
            status: 400,
            body: "Missing parameters"
        };
        context.done()
    }
    else {
        let result = await my_module.createNewTask(planid, bucketid, assigneeid, assigneename,reporterid, reportername, title, description, status_value, startdate, duedate)
        context.res = {
            status: 200,
            body: {"Task ID" : '' + result}
        };
        context.done()
        
    }
};