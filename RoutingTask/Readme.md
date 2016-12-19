Zaprojektuj tablicę routingu w nowo utworzonej, pustej aplikacji ASP.NET MVC tak, aby spełniała następujące wymagania:
 
•	Domyślnie, pierwszy człon adresu URL powinien oznaczać nazwę kontrolera a drugi człon nazwę akcji (np. http://twojadomena.com/products/list ma prowadzić do kontrolera ProductsController i jego akcji List). Jeśli parametry nie zostaną wprowadzone, domyślnie trasa powinna prowadzić do kontrolera StaticController i jego akcji Index.

•	Adresy, który drugich człon to "gatunki" - takie jak http://twojadomena.com/gatunki/rock, http://twojadomena.com/gatunki/pop powinny prowadzić do kontrolera ProductsController i jego akcji Index. Ostatni człon adresu (np. rock, pop) powinien być przekazywany jako parametr string metody Index.

•	Adres, którego pierwszy człon to "onas" (np. http://twojadomena.com/onas) powinien kierować do kontrolera StaticController i jego akcji About.
 
Sam zdecyduj, czy wolisz skorzystać z atrybutów czy klasycznej tablicy tras. W razie problemów lub w ramach ćwiczeń możesz także skorzystać z narzędzia Route Debugger, aby zweryfikować działanie swoich tras.
