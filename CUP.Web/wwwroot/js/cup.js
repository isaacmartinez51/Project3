pageSetUp();

// pagefunction
var pagefunction = function () {
    //console.log("cleared");

    /* // DOM Position key index //

        l - Length changing (dropdown)
        f - Filtering input (search)
        t - The Table! (datatable)
        i - Information (records)
        p - Pagination (paging)
        r - pRocessing
        < and > - div elements
        <"#id" and > - div with an id
        <"class" and > - div with a class
        <"#id.class" and > - div with an id and class

        Also see: http://legacy.datatables.net/usage/features
    */

    /* BASIC ;*/
    var responsiveHelper_dt_basic = undefined;
    var responsiveHelper_datatable_fixed_column = undefined;
    var responsiveHelper_datatable_col_reorder = undefined;
    var responsiveHelper_datatable_tabletools = undefined;

    var breakpointDefinition = {
        tablet: 1024,
        phone: 480
    };

    $('#dt_basic').dataTable({
        "preDrawCallback": function () {
            // Initialize the responsive datatables helper once.
            if (!responsiveHelper_dt_basic) {
                responsiveHelper_dt_basic =
                    new ResponsiveDatatablesHelper($('#dt_basic'), breakpointDefinition);
            }
        },
        "rowCallback": function (nRow) {
            responsiveHelper_dt_basic.createExpandIcon(nRow);
        },
        "drawCallback": function (oSettings) {
            responsiveHelper_dt_basic.respond();
        },
        "autoWidth": true,
        dom: 'Bfrtip',
        buttons: [
            //'copy', 'csv', 'excel', 'pdf', 'print', 
            {
                extend: 'copyHtml5',
                exportOptions: {
                    columns: ':not(:last-child)'
                }
            },
            {
                extend: 'excelHtml5',
                exportOptions: {
                    columns: ':not(:last-child)'
                }
            },
            {
                extend: 'pdfHtml5',
                exportOptions: {
                    columns: ':not(:last-child)'
                }
            },
            'colvis'
        ],
        "language": {
            "lengthMenu": "Mostrar _MENU_ registros por pagina",
            "zeroRecords": "Ningun registro",
            "info": "Mostrando pagina _PAGE_ de _PAGES_",
            "infoEmpty": "No hay registros disponibles",
            "infoFiltered": "(filtrando de _MAX_ total de registros)",
            "search": "Buscar",
            "paginate": {
                "previous": "<",
                "next": ">"
            }
        }
    });

    $('#dt_demo').dataTable({
        "preDrawCallback": function () {
            // Initialize the responsive datatables helper once.
            if (!responsiveHelper_dt_basic) {
                responsiveHelper_dt_basic =
                    new ResponsiveDatatablesHelper($('#dt_demo'), breakpointDefinition);
            }
        },
        "rowCallback": function (nRow) {
            responsiveHelper_dt_basic.createExpandIcon(nRow);
        },
        "drawCallback": function (oSettings) {
            responsiveHelper_dt_basic.respond();
        },
        "autoWidth": true,
        dom: 'Bfrtip',
        "language": {
            "lengthMenu": "Mostrar _MENU_ registros por pagina",
            "zeroRecords": "Ningun registro",
            "info": "Mostrando pagina _PAGE_ de _PAGES_",
            "infoEmpty": "No hay registros disponibles",
            "infoFiltered": "(filtrando de _MAX_ total de registros)",
            "search": "Buscar",
            "paginate": {
                "previous": "<",
                "next": ">"
            }
        }
    });
};





// load related plugins

loadScript("js/plugin/datatables/update/jquery.dataTables.min.js",
    function () {
        loadScript("js/plugin/datatables/dataTables.colVis.min.js",
            function () {
                loadScript("js/plugin/datatables/update/buttons.colVis.min.js",
                    function () {
                        loadScript("js/plugin/datatables/dataTables.bootstrap.min.js",
                            function () {
                                loadScript("js/plugin/datatable-responsive/datatables.responsive.min.js",
                                    function () {
                                        loadScript("js/plugin/datatables/update/dataTables.buttons.min.js",
                                            function () {
                                                loadScript("js/plugin/datatables/update/buttons.flash.min.js",
                                                    function () {
                                                        loadScript("js/plugin/datatables/update/jszip.min.js",
                                                            function () {
                                                                loadScript("js/plugin/datatables/update/pdfmake.min.js",
                                                                    function () {
                                                                        loadScript("js/plugin/datatables/update/vfs_fonts.js",
                                                                            function () {
                                                                                loadScript("js/plugin/datatables/update/buttons.html5.min.js",
                                                                                    function () {
                                                                                        loadScript("js/plugin/datatables/update/buttons.print.min.js",
                                                                                            pagefunction);
                                                                                    });
                                                                            });
                                                                    });
                                                            });
                                                    });
                                            });
                                    });
                            });
                    });
            });
    });