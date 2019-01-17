// function to add new Bucket to one Plan
// method: GET
// params: 

module.exports = async function (context, req) {
    context.log('JavaScript HTTP trigger function processed a request.');

    var my_module = require('../node_modules/capstone')

    var userid = req.body.userid;
    var name = req.body.name;
    var planid = req.body.planid;
    var role = req.body.role;

    context.log("userid : " + userid)
    context.log("name : " + name)
    context.log("planid : " + planid)
    context.log("role : " + role)


    if (!(userid && planid && role)) {
        context.res = {
            status: 400,
            body: "Missing parameters"
        };
        context.done()
    }
    else {
        let result = await my_module.addMemberToPlan(userid, name, planid, role)
        context.res = {
            status: 200,
            body: {"Added memberID" : ''+ result}
        };
        context.done()
    }
};