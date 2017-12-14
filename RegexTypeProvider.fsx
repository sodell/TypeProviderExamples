// reference the type provider dll
#r "packages/FSharp.Text.RegexProvider.1.0.0/lib/net40/FSharp.Text.RegexProvider.dll"
open FSharp.Text.RegexProvider

type BasicSentenceStructureRegex = Regex< @"^(?<NounArticle>.*)\s(?<Noun>.*)\s(?<Verb>.*)\s(?<ObjectArticle>.*)\s(?<Object>.*)\.$" >

// now you have typed access to the regex groups and you can browse it via Intellisense
BasicSentenceStructureRegex().TypedMatch("The man wrecked the car.").NounArticle.Value
BasicSentenceStructureRegex().TypedMatch("The man wrecked the car.").Noun.Value
BasicSentenceStructureRegex().TypedMatch("The man wrecked the car.").Verb.Value
BasicSentenceStructureRegex().TypedMatch("The man wrecked the car.").ObjectArticle.Value
BasicSentenceStructureRegex().TypedMatch("The man wrecked the car.").Object.Value

let nouns =
    [ "The man wrecked the car."; "The dog bit the cat."; "A monster consumed the child." ]
  |> List.map (fun x -> BasicSentenceStructureRegex().TypedMatch(x).Noun.Value)

// Now lets do one interactively... maybe try mathematical binary operator? <LeftOperand><Operator><RightOperand>

type BinaryOperatorMathExpressionRegex = Regex< @"^(?<LeftOperand>\d*[\.]\d*)(?<Operator>[-+\\\*])(?<RightOperand>\d*[\.]\d*)$" >
BinaryOperatorMathExpressionRegex().TypedMatch("12.4*3.2").LeftOperand.Value
BinaryOperatorMathExpressionRegex().TypedMatch("12.4*3.2").Operator.Value
BinaryOperatorMathExpressionRegex().TypedMatch("12.4*3.2").RightOperand.Value