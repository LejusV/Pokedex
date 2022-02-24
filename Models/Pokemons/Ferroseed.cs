using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Ferroseed Specie to store common natural stats of every {'abilities': ['iron-barbs'], 'base_experience': 61, 'height': 6, 'id': 597, 'moves': ['tackle', 'pin-missile', 'leech-seed', 'solar-beam', 'thunderbolt', 'thunder-wave', 'toxic', 'double-team', 'harden', 'self-destruct', 'flash', 'explosion', 'rest', 'substitute', 'snore', 'curse', 'protect', 'spikes', 'giga-drain', 'rollout', 'swagger', 'sleep-talk', 'return', 'frustration', 'metal-claw', 'hidden-power', 'sunny-day', 'rock-smash', 'facade', 'nature-power', 'ingrain', 'knock-off', 'endeavor', 'secret-power', 'bullet-seed', 'iron-defense', 'gravity', 'gyro-ball', 'payback', 'worry-seed', 'magnet-rise', 'rock-polish', 'poison-jab', 'seed-bomb', 'energy-ball', 'mirror-shot', 'flash-cannon', 'rock-climb', 'iron-head', 'stealth-rock', 'hone-claws', 'acid-spray', 'round', 'confide'], 'name': 'ferroseed', 'stats': {'hp': 44, 'attack': 50, 'defense': 91, 'special-attack': 24, 'special-defense': 86, 'speed': 10}, 'types': ['grass', 'steel'], 'weight': 188, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'gray', 'shape': 'ball', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['plant', 'mineral'], 'names': {'ja-Hrkt': 'テッシード', 'ko': '철시드', 'zh-Hant': '種子鐵球', 'fr': 'Grindur', 'de': 'Kastadur', 'es': 'Ferroseed', 'it': 'Ferroseed', 'en': 'Ferroseed', 'ja': 'テッシード', 'zh-Hans': '种子铁球'}, 'genera': {'ja-Hrkt': 'とげのみポケモン', 'ko': '가시열매포켓몬', 'zh-Hant': '刺果寶可夢', 'fr': 'Pokémon Graine Épine', 'de': 'Dornfrucht', 'es': 'Pokémon Fruto Espina', 'it': 'Pokémon Spinaseme', 'en': 'Thorn Seed Pokémon', 'ja': 'とげのみポケモン', 'zh-Hans': '刺果宝可梦'}}
	public class SpecieFerroseed : PokemonSpecie
	{
#nullable enable
		private static SpecieFerroseed? _instance = null;
#nullable restore
        public static SpecieFerroseed Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFerroseed();
                }
                return _instance;
            }
        }

		public SpecieFerroseed() : base(
			"Ferroseed",
			44, // HPs
			50, 91, // Attack & Defense
			24, 86, // Special Attack & Defense
			10			
		) {}
	}


	//Ferroseed Pokemon Class
	public class Ferroseed : Pokemon
	{

		public Ferroseed(string nickname, int level)
		: base(
				597,
				SpecieFerroseed.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Ferroseed() : base(
			597,
			SpecieFerroseed.Instance, // Pokemon Specie
			Grass.Instance, Steel.Instance			
		) {}
	}
}