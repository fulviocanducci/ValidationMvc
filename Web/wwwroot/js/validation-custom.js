(function ($) {
   $.validator.setDefaults({
      ignore: []
   });
   $.validator.addMethod('data-val-date-custom',
      function (value, element, params) {
         console.log(value);
         if (!value) return false;
         if (value.length < 10) return false;         
         return isDate(value, formatDate.dateOfBr);
      }, function (params, element) {
         let msgCompare = $(element).attr('data-val-date-custom');
         if (!msgCompare) {
            msgCompare = 'Date invalid';
         }
         return msgCompare;
      });
   $.validator.unobtrusive.adapters.addBool('data-val-date-custom');
})(jQuery);