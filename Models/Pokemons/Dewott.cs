using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dewott Specie to store common natural stats of every {'abilities': ['torrent', 'shell-armor'], 'base_experience': 145, 'height': 8, 'id': 502, 'moves': ['swords-dance', 'cut', 'tackle', 'tail-whip', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'dig', 'toxic', 'double-team', 'focus-energy', 'waterfall', 'rest', 'substitute', 'snore', 'protect', 'icy-wind', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'encore', 'iron-tail', 'hidden-power', 'rain-dance', 'rock-smash', 'hail', 'facade', 'taunt', 'helping-hand', 'revenge', 'secret-power', 'dive', 'aerial-ace', 'covet', 'water-sport', 'water-pulse', 'fling', 'aqua-tail', 'x-scissor', 'grass-knot', 'aqua-jet', 'round', 'scald', 'retaliate', 'water-pledge', 'work-up', 'razor-shell', 'confide'], 'name': 'dewott', 'stats': {'hp': 75, 'attack': 75, 'defense': 60, 'special-attack': 83, 'special-defense': 60, 'speed': 60}, 'types': ['water'], 'weight': 245, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'フタチマル', 'ko': '쌍검자비', 'zh-Hant': '雙刃丸', 'fr': 'Mateloutre', 'de': 'Zwottronin', 'es': 'Dewott', 'it': 'Dewott', 'en': 'Dewott', 'ja': 'フタチマル', 'zh-Hans': '双刃丸'}, 'genera': {'ja-Hrkt': 'しゅぎょうポケモン', 'ko': '수행포켓몬', 'zh-Hant': '修行寶可夢', 'fr': 'Pokémon Entraînement', 'de': 'Schulung', 'es': 'Pokémon Superación', 'it': 'Pokémon Apprendista', 'en': 'Discipline Pokémon', 'ja': 'しゅぎょうポケモン', 'zh-Hans': '修行宝可梦'}}
	public class SpecieDewott : PokemonSpecie
	{
#nullable enable
		private static SpecieDewott? _instance = null;
#nullable restore
        public static SpecieDewott Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDewott();
                }
                return _instance;
            }
        }

		public SpecieDewott() : base(
			"Dewott",
			75, // HPs
			75, 60, // Attack & Defense
			83, 60, // Special Attack & Defense
			60			
		) {}
	}


	//Dewott Pokemon Class
	public class Dewott : Pokemon
	{

		public Dewott(string nickname, int level)
		: base(
				502,
				SpecieDewott.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dewott() : base(
			502,
			SpecieDewott.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}