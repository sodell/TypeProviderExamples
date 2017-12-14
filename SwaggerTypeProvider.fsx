#r "packages/SwaggerProvider.0.8.1/lib/net45/SwaggerProvider.dll"
#r "packages/SwaggerProvider.0.8.1/lib/net45/SwaggerProvider.Runtime.dll"
open SwaggerProvider

// http://petstore.swagger.io/
let [<Literal>]schema = "http://petstore.swagger.io/v2/swagger.json"
//type PetStore = SwaggerProvider<schema> // Provided Types
//let petStore = PetStore()
//let pet = petStore.GetPetById((int64)5)
