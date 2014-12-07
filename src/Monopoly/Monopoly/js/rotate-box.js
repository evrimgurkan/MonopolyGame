var init = function() {
  var box = document.querySelector('.container').children[0],
      showPanelButtons = document.querySelectorAll('#show-buttons button'),
      panelClassName = 'show-front',
	  panelClassName2 = 'show-front',
      box2 = document.getElementById("cube2"),
	  
      onButtonClick = function( event ){
        box.removeClassName( panelClassName );
        panelClassName = event.target.className;
        box.addClassName( panelClassName );
		box2.removeClassName( panelClassName2 );
		panelClassName2 = event.target.className;
		box2.addClassName( panelClassName2 );
      };

  for (var i=0, len = showPanelButtons.length; i < len; i++) {
    showPanelButtons[i].addEventListener( 'click', onButtonClick, false);
  }  
};
  
window.addEventListener( 'DOMContentLoaded', init, false);