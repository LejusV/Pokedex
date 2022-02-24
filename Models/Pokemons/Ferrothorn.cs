using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Ferrothorn Specie to store common natural stats of every {'abilities': ['iron-barbs', 'anticipation'], 'base_experience': 171, 'height': 10, 'id': 598, 'moves': ['swords-dance', 'cut', 'tackle', 'pin-missile', 'hyper-beam', 'strength', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'double-team', 'harden', 'self-destruct', 'flash', 'explosion', 'rest', 'substitute', 'snore', 'curse', 'protect', 'sandstorm', 'giga-drain', 'rollout', 'swagger', 'sleep-talk', 'return', 'frustration', 'metal-claw', 'hidden-power', 'sunny-day', 'rock-smash', 'facade', 'nature-power', 'ingrain', 'knock-off', 'endeavor', 'secret-power', 'aerial-ace', 'iron-defense', 'block', 'gravity', 'gyro-ball', 'payback', 'worry-seed', 'magnet-rise', 'rock-polish', 'poison-jab', 'seed-bomb', 'energy-ball', 'giga-impact', 'shadow-claw', 'mirror-shot', 'flash-cannon', 'rock-climb', 'power-whip', 'iron-head', 'stealth-rock', 'grass-knot', 'hone-claws', 'round', 'bulldoze', 'confide'], 'name': 'ferrothorn', 'stats': {'hp': 74, 'attack': 94, 'defense': 131, 'special-attack': 54, 'special-defense': 116, 'speed': 20}, 'types': ['grass', 'steel'], 'weight': 1100, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 90, 'color': 'gray', 'shape': 'tentacles', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['plant', 'mineral'], 'names': {'ja-Hrkt': 'ナットレイ', 'ko': '너트령', 'zh-Hant': '堅果啞鈴', 'fr': 'Noacier', 'de': 'Tentantel', 'es': 'Ferrothorn', 'it': 'Ferrothorn', 'en': 'Ferrothorn', 'ja': 'ナットレイ', 'zh-Hans': '坚果哑铃'}, 'genera': {'ja-Hrkt': 'とげだまポケモン', 'ko': '가시공포켓몬', 'zh-Hant': '刺球寶可夢', 'fr': 'Pokémon Boule Épine', 'de': 'Dornkugel', 'es': 'Pokémon Bola Espina', 'it': 'Pokémon Spinasfere', 'en': 'Thorn Pod Pokémon', 'ja': 'とげだまポケモン', 'zh-Hans': '刺球宝可梦'}}
	public class SpecieFerrothorn : PokemonSpecie
	{
#nullable enable
		private static SpecieFerrothorn? _instance = null;
#nullable restore
        public static SpecieFerrothorn Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFerrothorn();
                }
                return _instance;
            }
        }

		public SpecieFerrothorn() : base(
			"Ferrothorn",
			74, // HPs
			94, 131, // Attack & Defense
			54, 116, // Special Attack & Defense
			20			
		) {}
	}


	//Ferrothorn Pokemon Class
	public class Ferrothorn : Pokemon
	{

		public Ferrothorn(string nickname, int level)
		: base(
				598,
				SpecieFerrothorn.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Ferrothorn() : base(
			598,
			SpecieFerrothorn.Instance, // Pokemon Specie
			Grass.Instance, Steel.Instance			
		) {}
	}
}