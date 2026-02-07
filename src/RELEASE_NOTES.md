## 0.9.0

* feat: add condition check to `ObjectLink` (#51)
* chore(dependencies)!: update `Shilazeron` to `v0.13.0` (#51)
* refactor!: move all condition checks to `Expr` module (#50)

## 0.8.0

* refactor!: rename `display` in variables, functions (#47)
* refactor!: rename `Display` in `SetLocationArguments` to `Description` (#46)
* refactor!: rename `ExecError.DisplayStatement` to `ExecError.SentenceStatement` in `Sentence` (#43)
* refactor!: rename `DisplayStatement` to `SentenceStatement` (#41)
* refactor!: rename `EngineDisplays` to `EngineDescription` (#39)
* feat!: update `Shilazeron` to `v0.12.0` (#37)

## 0.7.0

* feat!: update `Shilazeron` to `v0.11.0` (#36)
* refactor!: rename `Description.ExecResult` to `Description.ExecError` (#35)
* refactor!: make alias types as internal (#34)
* feat!: update `Shilazeron` to `v0.10.0` (#32)

## 0.6.1

* fix(Statement.AddObjectToHero): object not adding to state (#30)

## 0.6.0

* feat: add `Interactive.GetInventoryObjectName` (#27)
* feat!: add `ObjectName` argument to `Response.AddObjectToHero` (#26)

## 0.5.0

* feat!: add select inventory object (#22)
* feat!: improve abstract (#21)
* refactor(Statements)!: remove `'Next` subtype from `ExecResult` (#20)

## 0.4.1

* feat(Statement): handle `Take` and `Put` via `AddObjectToHero` and `RemoveObjectFromHero` ([#18](https://github.com/lapkiteam/Shilazeron.Engine/issues/18))

## 0.4.0

* feat(Statement)!: add `AddObjectToHero` and `RemoveObjectFromHero` (#15)

## 0.3.1

* feat: include sources for Fable

## 0.3.0

* refactor!: rename `tryFind` to `tryFindLinkAction` (#10)
* feat: add `tryFindObjectAction` to `EngineDisplays`, `EngineSentence` and `EngineSentenceStatement` modules (#9)

## 0.2.0

* feat!: update `Core` to v0.8.0

## 0.1.0

* feat: copy project from Shilazeron
