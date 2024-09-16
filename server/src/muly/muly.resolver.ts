import * as graphql from "@nestjs/graphql";
import { MulyResolverBase } from "./base/muly.resolver.base";
import { Muly } from "./base/Muly";
import { MulyService } from "./muly.service";

@graphql.Resolver(() => Muly)
export class MulyResolver extends MulyResolverBase {
  constructor(protected readonly service: MulyService) {
    super(service);
  }
}
