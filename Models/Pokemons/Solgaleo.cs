using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Solgaleo Specie to store common natural stats of every {'abilities': ['full-metal-body'], 'base_experience': 306, 'height': 34, 'id': 791, 'moves': ['roar', 'flamethrower', 'hyper-beam', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'toxic', 'psychic', 'teleport', 'double-team', 'light-screen', 'reflect', 'fire-blast', 'rest', 'rock-slide', 'substitute', 'protect', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'metal-claw', 'morning-sun', 'hidden-power', 'sunny-day', 'crunch', 'psych-up', 'facade', 'rock-tomb', 'metal-sound', 'cosmic-power', 'calm-mind', 'wake-up-slap', 'gyro-ball', 'metal-burst', 'flare-blitz', 'focus-blast', 'giga-impact', 'zen-headbutt', 'flash-cannon', 'trick-room', 'iron-head', 'stone-edge', 'wide-guard', 'psyshock', 'flame-charge', 'round', 'bulldoze', 'work-up', 'wild-charge', 'snarl', 'noble-roar', 'confide', 'sunsteel-strike'], 'name': 'solgaleo', 'stats': {'hp': 137, 'attack': 137, 'defense': 107, 'special-attack': 113, 'special-defense': 89, 'speed': 97}, 'types': ['psychic', 'steel'], 'weight': 2300, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 45, 'color': 'white', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ソルガレオ', 'ko': '솔가레오', 'zh-Hant': '索爾迦雷歐', 'fr': 'Solgaleo', 'de': 'Solgaleo', 'es': 'Solgaleo', 'it': 'Solgaleo', 'en': 'Solgaleo', 'ja': 'ソルガレオ', 'zh-Hans': '索尔迦雷欧'}, 'genera': {'ja-Hrkt': 'にちりんポケモン', 'ko': '일륜포켓몬', 'zh-Hant': '日輪寶可夢', 'fr': 'Pokémon Halo Solaire', 'de': 'Sonnenkreis', 'es': 'Pokémon Corona Solar', 'it': 'Pokémon Solare', 'en': 'Sunne Pokémon', 'ja': 'にちりんポケモン', 'zh-Hans': '日轮宝可梦'}}
	public class SpecieSolgaleo : PokemonSpecie
	{
#nullable enable
		private static SpecieSolgaleo? _instance = null;
#nullable restore
        public static SpecieSolgaleo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSolgaleo();
                }
                return _instance;
            }
        }

		public SpecieSolgaleo() : base(
			"Solgaleo",
			137, // HPs
			137, 107, // Attack & Defense
			113, 89, // Special Attack & Defense
			97			
		) {}
	}


	//Solgaleo Pokemon Class
	public class Solgaleo : Pokemon
	{

		public Solgaleo(string nickname, int level)
		: base(
				791,
				SpecieSolgaleo.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Solgaleo() : base(
			791,
			SpecieSolgaleo.Instance, // Pokemon Specie
			Psychic.Instance, Steel.Instance			
		) {}
	}
}