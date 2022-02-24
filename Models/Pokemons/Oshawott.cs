using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Oshawott Specie to store common natural stats of every {'abilities': ['torrent', 'shell-armor'], 'base_experience': 62, 'height': 5, 'id': 501, 'moves': ['swords-dance', 'cut', 'tackle', 'tail-whip', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'dig', 'toxic', 'screech', 'double-team', 'focus-energy', 'waterfall', 'rest', 'substitute', 'snore', 'protect', 'icy-wind', 'detect', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'encore', 'iron-tail', 'hidden-power', 'rain-dance', 'rock-smash', 'hail', 'facade', 'taunt', 'helping-hand', 'revenge', 'secret-power', 'dive', 'aerial-ace', 'covet', 'water-sport', 'water-pulse', 'brine', 'assurance', 'fling', 'trump-card', 'copycat', 'night-slash', 'aqua-tail', 'air-slash', 'x-scissor', 'grass-knot', 'aqua-jet', 'round', 'scald', 'retaliate', 'water-pledge', 'work-up', 'sacred-sword', 'razor-shell', 'confide'], 'name': 'oshawott', 'stats': {'hp': 55, 'attack': 55, 'defense': 45, 'special-attack': 63, 'special-defense': 45, 'speed': 45}, 'types': ['water'], 'weight': 59, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ミジュマル', 'ko': '수댕이', 'zh-Hant': '水水獺', 'fr': 'Moustillon', 'de': 'Ottaro', 'es': 'Oshawott', 'it': 'Oshawott', 'en': 'Oshawott', 'ja': 'ミジュマル', 'zh-Hans': '水水獭'}, 'genera': {'ja-Hrkt': 'ラッコポケモン', 'ko': '해달포켓몬', 'zh-Hant': '海獺寶可夢', 'fr': 'Pokémon Loutre', 'de': 'Otter', 'es': 'Pokémon Nutria', 'it': 'Pokémon Lontra', 'en': 'Sea Otter Pokémon', 'ja': 'ラッコポケモン', 'zh-Hans': '海獭宝可梦'}}
	public class SpecieOshawott : PokemonSpecie
	{
#nullable enable
		private static SpecieOshawott? _instance = null;
#nullable restore
        public static SpecieOshawott Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieOshawott();
                }
                return _instance;
            }
        }

		public SpecieOshawott() : base(
			"Oshawott",
			55, // HPs
			55, 45, // Attack & Defense
			63, 45, // Special Attack & Defense
			45			
		) {}
	}


	//Oshawott Pokemon Class
	public class Oshawott : Pokemon
	{

		public Oshawott(string nickname, int level)
		: base(
				501,
				SpecieOshawott.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Oshawott() : base(
			501,
			SpecieOshawott.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}