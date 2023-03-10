dayjs.locale('pt-br');
dayjs.extend(window.dayjs_plugin_customParseFormat);
const formatDate = {
   dateOfBr: 'DD/MM/YYYY',
   dateTimeOfBr: 'DD/MM/YYYY HH:mm:ss'
}
function isDate(value, format) {
   const result = dayjs(value, format, true).isValid();
   return result;
}