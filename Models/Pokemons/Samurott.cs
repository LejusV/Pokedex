using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Samurott Specie to store common natural stats of every {'abilities': ['torrent', 'shell-armor'], 'base_experience': 238, 'height': 15, 'id': 503, 'moves': ['swords-dance', 'cut', 'tackle', 'tail-whip', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'dig', 'toxic', 'double-team', 'focus-energy', 'waterfall', 'rest', 'slash', 'substitute', 'snore', 'protect', 'icy-wind', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'megahorn', 'encore', 'iron-tail', 'hidden-power', 'rain-dance', 'rock-smash', 'hail', 'facade', 'taunt', 'helping-hand', 'superpower', 'revenge', 'knock-off', 'secret-power', 'dive', 'hydro-cannon', 'aerial-ace', 'block', 'covet', 'water-sport', 'water-pulse', 'fling', 'aqua-tail', 'x-scissor', 'giga-impact', 'grass-knot', 'aqua-jet', 'round', 'scald', 'retaliate', 'water-pledge', 'dragon-tail', 'work-up', 'razor-shell', 'confide', 'smart-strike'], 'name': 'samurott', 'stats': {'hp': 95, 'attack': 100, 'defense': 85, 'special-attack': 108, 'special-defense': 70, 'speed': 70}, 'types': ['water'], 'weight': 946, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ダイケンキ', 'ko': '대검귀', 'zh-Hant': '大劍鬼', 'fr': 'Clamiral', 'de': 'Admurai', 'es': 'Samurott', 'it': 'Samurott', 'en': 'Samurott', 'ja': 'ダイケンキ', 'zh-Hans': '大剑鬼'}, 'genera': {'ja-Hrkt': 'かんろくポケモン', 'ko': '관록포켓몬', 'zh-Hant': '威嚴寶可夢', 'fr': 'Pokémon Dignitaire', 'de': 'Würde', 'es': 'Pokémon Majestuoso', 'it': 'Pokémon Dignità', 'en': 'Formidable Pokémon', 'ja': 'かんろくポケモン', 'zh-Hans': '威严宝可梦'}}
	public class SpecieSamurott : PokemonSpecie
	{
#nullable enable
		private static SpecieSamurott? _instance = null;
#nullable restore
        public static SpecieSamurott Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSamurott();
                }
                return _instance;
            }
        }

		public SpecieSamurott() : base(
			"Samurott",
			95, // HPs
			100, 85, // Attack & Defense
			108, 70, // Special Attack & Defense
			70			
		) {}
	}


	//Samurott Pokemon Class
	public class Samurott : Pokemon
	{

		public Samurott(string nickname, int level)
		: base(
				503,
				SpecieSamurott.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Samurott(int level)
		: base(
				503,
				SpecieSamurott.Instance, // Pokemon Specie
				"Samurott", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Samurott() : base(
			503,
			SpecieSamurott.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}