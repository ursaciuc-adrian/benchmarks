
# Object Mapper Benchmarks

## AutoMapper
- Uses reflection which makes it slower than others

## EmitMapper

### Good
- Pretty fast

### Bad
- Old
- Little to no documentation
- Small community for support
- Shady stuff has to be done in order for it to work with IEnumerables https://stackoverflow.com/questions/9568225/emitmapper-and-list/40220655#40220655

## TinyMapper
- Needs additional configuration in order to work with IEnumerables

## AgileMapper
- Zero configuration needed

## Mapster
- Step-into debugging
- Fast
- Simple to set up

## Benchmarks
Objects mapped for tests: 
- 1000 objects of type A
- each object of type A has a list containing 100 objects of type B
- each object of type B has a list containing 10 objects of type C

| Mapper | Time |
|--|--|
| ExpressMapper | 380 ms |
| TinyMapper | 299 ms |
| AutoMapper | 281 ms |
| **Manual** | 271 ms |
| EmitMapper | 256 ms |
| AgileMapper | 222 ms |
| Mapster | 221 ms |

