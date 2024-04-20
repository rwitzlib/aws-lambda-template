variable "environment" {
    type = string
    default = "dev"
}

variable "image_tag" {
    type        = string
    description = "This is the image name that will be populated by the pipeline."
}