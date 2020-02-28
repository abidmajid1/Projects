
$('document').ready(function() {
  setInterval(submitForm(), 20000); 
});

function submitForm() {
  $("#healthUpdate").submit();
}