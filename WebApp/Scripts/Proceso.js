
    $('#IdUsuarioOrigen').on('focus', function () {
        $(this).attr('style', 'border-color:red');
    });

    $('#IdUsuarioOrigen').on('focusout', function () {
        $(this).removeAttr('style');
    });

    
    
    $("input[id=PorUsuario]").on('change', function () {
        if ($(this).is(':checked')) {            
            $('#GrupUsuario').removeAttr('hidden');  
            $("#PorDepartamento").attr('checked', false);
            $("#TodosUsuarios").attr('checked', false);
            $('#GrupDepa').attr('hidden', 'hidden');
        }
        else {
            $('#GrupUsuario').attr('hidden', 'hidden');
            
        }
    });
    
    $('#PorDepartamento').on('change', function () {
        if ($(this).is(':checked')) {
            $('#GrupDepa').removeAttr('hidden');
            $("#PorUsuario").attr('checked', false);
            $("#TodosUsuarios").attr('checked', false);
            $('#GrupUsuario').attr('hidden', 'hidden');
        }
        else {
            $('#GrupDepa').attr('hidden', 'hidden');
        }
    });

    $('#TodosUsuarios').on('change', function () {
        if ($(this).is(':checked')) {
            $("#PorUsuario").attr('checked', false);
            $("#PorDepartamento").attr('checked', false);
            $('#GrupDepa').attr('hidden', 'hidden');
            $('#GrupUsuario').attr('hidden', 'hidden');

        }
        
    });


    $(document).ready(function () {
        
    });
