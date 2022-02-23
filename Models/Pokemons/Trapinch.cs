using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Trapinch Specie to store common natural stats of every {'abilities': ['hyper-cutter', 'arena-trap', 'sheer-force'], 'base_experience': 58, 'height': 7, 'id': 328, 'moves': ['gust', 'sand-attack', 'headbutt', 'body-slam', 'double-edge', 'bite', 'hyper-beam', 'strength', 'solar-beam', 'earthquake', 'fissure', 'dig', 'toxic', 'quick-attack', 'mimic', 'double-team', 'focus-energy', 'bide', 'rest', 'rock-slide', 'substitute', 'snore', 'flail', 'protect', 'feint-attack', 'mud-slap', 'sandstorm', 'giga-drain', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'sunny-day', 'crunch', 'rock-smash', 'facade', 'superpower', 'secret-power', 'rock-tomb', 'signal-beam', 'sand-tomb', 'mud-shot', 'natural-gift', 'feint', 'earth-power', 'captivate', 'bug-bite', 'round', 'struggle-bug', 'bulldoze', 'confide'], 'name': 'trapinch', 'stats': {'hp': 45, 'attack': 100, 'defense': 45, 'special-attack': 45, 'special-defense': 45, 'speed': 10}, 'types': ['ground'], 'weight': 150, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'armor', 'habitat': 'rough-terrain', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'ナックラー', 'roomaji': 'Nuckrar', 'ko': '톱치', 'zh-Hant': '大顎蟻', 'fr': 'Kraknoix', 'de': 'Knacklion', 'es': 'Trapinch', 'it': 'Trapinch', 'en': 'Trapinch', 'ja': 'ナックラー', 'zh-Hans': '大颚蚁'}, 'genera': {'ja-Hrkt': 'ありじごくポケモン', 'ko': '개미지옥포켓몬', 'zh-Hant': '蟻獅寶可夢', 'fr': 'Pokémon Piégeur', 'de': 'Ameisenlöwe', 'es': 'Pokémon Hormigaleón', 'it': 'Pokémon Trappola', 'en': 'Ant Pit Pokémon', 'ja': 'ありじごくポケモン', 'zh-Hans': '蚁狮宝可梦'}}
	public class SpecieTrapinch : PokemonSpecie
	{
#nullable enable
		private static SpecieTrapinch? _instance = null;
#nullable restore
        public static SpecieTrapinch Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTrapinch();
                }
                return _instance;
            }
        }

		public SpecieTrapinch() : base(
			"Trapinch",
			45, // HPs
			100, 45, // Attack & Defense
			45, 45, // Special Attack & Defense
			10			
		) {}
	}


	//Trapinch Pokemon Class
	public class Trapinch : Pokemon
	{

		public Trapinch(string nickname, int level) : base(
			328,
			SpecieTrapinch.Instance, // Pokemon Specie
			nickname, level,
			Ground.Instance			
		) {}

		public Trapinch() : base(
			328,
			SpecieTrapinch.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
	}
}