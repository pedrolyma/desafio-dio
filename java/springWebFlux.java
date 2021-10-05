import lombok.exterm.Slf4j.Slf4j;
import reactor.core.publisher.Flux;
import reactor.core.publisher.Mono;

@Slf4j
public class DemoReactApplication {
    public static void main(string[] args) {
        Flux.range(1, 5)  // mesmo result
        Flux.fromIterable(asList(1, 2, 3, 4, 5)) // mesmo result
        Flux.from(Mono.justOrEmpty(Optional.ofNullable("hello word"))) // passa opcional
        Flux.from(Mono.error(newRuntimeException("teste"))) // fluxo de erro
        boolean somentePares = true;
        Flux.defer(() => somentePares?   // defer para decisao
          Mono.from(Flux.range(1, 10).filter(p => p % 2 == 0)) :
          Mono.from(Flux.range(1, 10).filter(p => p != 0)))  
        Flux.range(1, 10)
        .filter(i -> i % 2 ==0)  // somente pares
        .map(i -> i * 2) // mult fluxo por 2             
        .repeat()  
        .timestamp()
        .index()  // mostra array 0 a x
        .subscribe(i => log.info('num: {}', i),
        e => log.info("elemento {} - {}", e.getT1(), e.getT2()), // index e elemento
        e -> log.info("index: {}, Time: {}, Data: {}", new Object[]{e.getT1(),
         Instant.ofEpochMilli(e.getT2().getT1()), e.getT2().getT2()}),
         error => log.error("erro" + error));

         subscriptor => {
             subscriptor.request(i: 4); // 4 itens ate quando
             subscriptor.cancel(); // parada
         }
    }

    private static RuntimeException newRuntimeException(String teste) {
        return new RuntimeException(teste);
    }
}