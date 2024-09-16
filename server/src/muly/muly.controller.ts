import * as common from "@nestjs/common";
import * as swagger from "@nestjs/swagger";
import { MulyService } from "./muly.service";
import { MulyControllerBase } from "./base/muly.controller.base";

@swagger.ApiTags("mulies")
@common.Controller("mulies")
export class MulyController extends MulyControllerBase {
  constructor(protected readonly service: MulyService) {
    super(service);
  }
}
