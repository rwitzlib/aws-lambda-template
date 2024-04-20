data "aws_ecr_image" "image" {
    repository_name = local.repository_name
    image_tag = var.image_tag
}