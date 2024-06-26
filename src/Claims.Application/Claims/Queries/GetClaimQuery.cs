﻿using Claims.Domain.Claims;
using MediatR;

namespace Claims.Application.Claims.Queries;
public sealed record GetClaimQuery(string ClaimId) : IRequest<ClaimReadModel?>;
