Each action component will store a struct {ActionRules} with 3 sets. AND, OR, ANDNOT.

the action will be able to retrieve these values, but they aren't to be stored there, since each part needs to be modified seperately.

when a passive/piece of gear etc wants to modify an item it will have its own ActionRules.

All AND rules must match up for a bonus to be applied,

any OR rule must match

No ANDNOT rules can match.

after that the passive etc will be able to apply any statchanges it wants.