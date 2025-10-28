// JScript File

var popUp;

function SetControlValue(controlID, newDate, isPostBack)
{
    popUp.close();    
    document.forms[0].elements[controlID].value=newDate;
    //document.getElementById(controlID).innerHTML  =newDate;
    //alert('abc : '+document.getElementById(controlID).innerText + 'newDate : '+newDate);
    __doPostBack(controlID,'');
}

function OpenPopupPage (pageUrl, controlID, isPostBack)
{
    popUp=window.open(pageUrl+'?cID='+controlID+'&isPB='+ isPostBack,'popupcal', 'width=800,height=600,left=100,top=250'); 
}

function OpenPopupHTCVPage (pageUrl, controlID, isPostBack, userId, month, year)
{
    popUp=window.open(pageUrl+'?cID='+controlID+'&isPB='+ isPostBack +'&uId='+ userId +'&m='+ month +'&y=' + year,'popupcal', 'width=800,height=600,left=100,top=250,scrollbars=1,resizable=1'); 
}
function OpenPopupEmployeeInforDetailPage (pageUrl, userId)
{
    popUp=window.open(pageUrl+'?uId='+ userId ,'popupcal', 'width=600,height=470,left=100,top=250,scrollbars=1,resizable=1');
}
function OpenPopupStockReport(pageUrl, userId) {
    popUp = window.open(pageUrl + '?uId=' + userId, 'popupcal', 'width=600,height=300,left=250,top=250,scrollbars=1,resizable=1');
}


function OpenPopupVoteReport(pageUrl, userId) {
    popUp = window.open(pageUrl + '?uId=' + userId, 'popupcal', 'width=800,height=580,left=250,top=250,scrollbars=1,resizable=1,location=no');
}