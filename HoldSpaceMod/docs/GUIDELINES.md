# Project Guidelines and Structure (ENGLISH)

## Recommended Structure
- `src/` : main source code
- `tests/` : unit and integration tests
- `docs/` : documentation, README, changelog
- `build/` : build scripts and configs
- `libs/` : external dependencies (DLL, packages)
- Config files (`.gitignore`, `nuget.config`, etc.) at root
- `Thunderstore/` : Thunderstore distribution (if applicable)

## Best Practices
1. **Do not version generated files** (`bin/`, `obj/`, etc.)
2. **Document the project**: README, changelog, install and usage instructions
3. **Use consistent naming conventions** for files, folders, classes, methods
4. **Separate concerns**: business logic, UI, data access
5. **Write useful comments**: clear, concise, not excessive
6. **Write unit tests** in `tests/`, automate if possible
7. **Automate**: build scripts, tests, lint, CI
8. **Update documentation** with every major change
9. **Respect licenses** for the project and dependencies
10. **Make contributing easy**: explain how to propose changes

## Minimal `.gitignore` example
```
# Files/folders to ignore
bin/
obj/
*.user
*.suo
*.userprefs
*.log
.vs/
Thunderstore/Thunderstore.zip
```

---

Follow these rules to ensure maintainability, clarity, and effective collaboration on the project.

---

# Bonnes pratiques et structure de projet (FRANÇAIS)

## Structure recommandée
- `src/` : code source principal
- `tests/` : tests unitaires et d’intégration
- `docs/` : documentation, README, changelog
- `build/` : scripts et configurations de build
- `libs/` : dépendances externes (DLL, packages)
- Fichiers de configuration (`.gitignore`, `nuget.config`, etc.) à la racine
- `Thunderstore/` : distribution spécifique (si applicable)

## Règles de bonnes pratiques
1. **Ne pas versionner les fichiers générés** (`bin/`, `obj/`, etc.)
2. **Documenter le projet** : README, changelog, instructions d’installation et d’utilisation
3. **Conventions de nommage** : cohérence pour fichiers, dossiers, classes, méthodes
4. **Séparation des responsabilités** : logique métier, interface, accès aux données
5. **Commentaires utiles** : clairs, concis, sans surcharger
6. **Tests unitaires** : placer dans `tests/`, automatiser si possible
7. **Automatisation** : scripts de build, tests, lint, CI
8. **Mise à jour de la documentation** à chaque modification majeure
9. **Respect des licences** pour le projet et les dépendances
10. **Faciliter la contribution** : expliquer comment proposer des changements

## Exemple de `.gitignore` minimal
```
# Fichiers/dossiers à ignorer
bin/
obj/
*.user
*.suo
*.userprefs
*.log
.vs/
Thunderstore/Thunderstore.zip
```

---

Adoptez ces règles pour garantir la maintenabilité, la clarté et la collaboration efficace sur le projet.
