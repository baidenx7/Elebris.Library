Character holds a collection of handlers, each representing a vertical slice of Elebris' Systems

Each Handler is created by a Builder which is responsible for Creating the handler, 
and populating its internal dictionaries etc from selected Factories

Factories are the "endpoint", each representing one of the collections that a handler oversees.

Factories will use different modules to populate different default structures
as some things (Like level) may not apply to all created characters