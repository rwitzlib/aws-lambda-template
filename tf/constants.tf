locals {
    team = ""
    business_domain = ""
    service_name = ""

    repository_name = "${local.team}-${var.stage}-${local.business_domain}-${local.service_name}"
}