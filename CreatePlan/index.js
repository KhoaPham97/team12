// function to add new Plan to DB
// method: GET
// params: title , description, startdate, duedate

module.exports = async function (context, req) {
    context.log('JavaScript HTTP trigger function processed a request.');

    var my_module = require('../node_modules/capstone')

    var title = req.body.title;
    var description = req.body.description;
    var startdate = req.body.startdate;
    var duedate = req.body.duedate;
    var status_value = req.body.status;

    context.log("title : " + title)
    context.log("description : " + description )
    context.log("startdate : " + startdate)
    context.log("duedate : " + duedate)
    context.log("status_value : " + status_value)

    if (!(title && description && startdate && duedate && status_value)) {
        context.res = {
            status: 400,
            body: "Missing parameters"
        };
    }
    else {
        let result = await my_module.createPlan(title, description, status_value, startdate, duedate)
        context.res = {
            status: 200,
            body: {"Plan ID" : '' + result}
        };
        context.done()
        
    }
};