using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Stock;
using api.Models;

namespace api.Mappers
{
    public static class StockMapper
    {
        public static StockDto ToStockDto(this Stock stockModel)
        {
            return new StockDto
            {
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Industry = stockModel.Industry,
                Purchase = stockModel.Purchase,
                LastDiv = stockModel.LastDiv,
                MarketCap = stockModel.MarketCap,
                Comments = stockModel.Comments.Select(c=>c.ToCommentDto()).ToList()
            };
        }

        public static Stock ToStockFromCreateDto(this CreateStockRequestDto createStockDto)
        {
            return new Stock
            {
                Symbol = createStockDto.Symbol,
                CompanyName = createStockDto.CompanyName,
                Industry = createStockDto.Industry,
                Purchase = createStockDto.Purchase,
                LastDiv = createStockDto.LastDiv,
                MarketCap = createStockDto.MarketCap
            };
        }

        public static Stock ToStockFromUpdateDto(this UpdateStockRequestDto updateStockDto){
            return new Stock
            {
                Symbol = updateStockDto.Symbol,
                CompanyName = updateStockDto.CompanyName,
                Industry = updateStockDto.Industry,
                Purchase = updateStockDto.Purchase,
                LastDiv = updateStockDto.LastDiv,
                MarketCap = updateStockDto.MarketCap
            };
        }
    }
}