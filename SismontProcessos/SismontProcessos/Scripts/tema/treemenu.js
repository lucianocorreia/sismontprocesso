jQuery.noConflict();
jQuery(document).ready(function () {
    jQuery('#side-menu').metisMenu();

    jQuery('.nav').on('click', '.bookmark', function () {
        var element = jQuery(this).attr('data-element');
        var link = jQuery(this).parent('a').attr('href');
        var text = jQuery(this).attr('data-name');

        if (jQuery(this).find('i').hasClass('fa-star-o')) {
            jQuery(this).find('i').removeClass('fa-star-o');
            jQuery(this).find('i').addClass('fa-star');

            jQuery('#bookmark').append('<li id="bookmark-' + element + '"><a href="' + link + '"><button class="bookmark" data-element="' + element + '" data-name="' + text + '"><i class="fa fa-star"></i></button> ' + text + '</a></li>')
        } else {
            jQuery('#bookmark #bookmark-' + element + '').remove();

            var id = jQuery(this).parent('a').parent('li').attr('id');
            if (id == 'bookmark-' + element) {
                jQuery('#' + element + ' a button i').removeClass('fa-star');
                jQuery('#' + element + ' a button i').addClass('fa-star-o');
            } else {
                jQuery(this).find('i').removeClass('fa-star');
                jQuery(this).find('i').addClass('fa-star-o');
            }

        }

        return false;
    });

    //Loads the correct sidebar on window load,
    //collapses the sidebar on window resize.
    jQuery(window).bind("load resize", function () {
        if (jQuery(this).width() < 768) {
            jQuery('div.sidebar-collapse').addClass('collapse');
        } else {
            jQuery('div.sidebar-collapse').removeClass('collapse');
        }
    });
});
