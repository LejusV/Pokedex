using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Metang Specie to store common natural stats of every {'abilities': ['clear-body', 'light-metal'], 'base_experience': 147, 'height': 12, 'id': 375, 'moves': ['ice-punch', 'thunder-punch', 'cut', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'hyper-beam', 'strength', 'earthquake', 'toxic', 'confusion', 'psychic', 'agility', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'reflect', 'self-destruct', 'swift', 'flash', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'scary-face', 'sludge-bomb', 'mud-slap', 'icy-wind', 'sandstorm', 'endure', 'rollout', 'swagger', 'fury-cutter', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'pursuit', 'metal-claw', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'facade', 'trick', 'brick-break', 'secret-power', 'meteor-mash', 'rock-tomb', 'signal-beam', 'aerial-ace', 'iron-defense', 'gravity', 'miracle-eye', 'gyro-ball', 'natural-gift', 'magnet-rise', 'rock-polish', 'bullet-punch', 'zen-headbutt', 'flash-cannon', 'iron-head', 'stealth-rock', 'grass-knot', 'hone-claws', 'psyshock', 'telekinesis', 'round', 'bulldoze', 'confide', 'power-up-punch'], 'name': 'metang', 'stats': {'hp': 60, 'attack': 75, 'defense': 100, 'special-attack': 55, 'special-defense': 80, 'speed': 50}, 'types': ['steel', 'psychic'], 'weight': 2025, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': -1, 'capture_rate': 3, 'color': 'blue', 'shape': 'arms', 'habitat': 'rough-terrain', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'メタング', 'roomaji': 'Metang', 'ko': '메탕구', 'zh-Hant': '金屬怪', 'fr': 'Métang', 'de': 'Metang', 'es': 'Metang', 'it': 'Metang', 'en': 'Metang', 'ja': 'メタング', 'zh-Hans': '金属怪'}, 'genera': {'ja-Hrkt': 'てつツメポケモン', 'ko': '철발톱포켓몬', 'zh-Hant': '鐵爪寶可夢', 'fr': 'Pokémon Pincefer', 'de': 'Eisenklaue', 'es': 'Pokémon Garra Hierro', 'it': 'Pokémon Ferrunghia', 'en': 'Iron Claw Pokémon', 'ja': 'てつツメポケモン', 'zh-Hans': '铁爪宝可梦'}}
	public class SpecieMetang : PokemonSpecie
	{
#nullable enable
		private static SpecieMetang? _instance = null;
#nullable restore
        public static SpecieMetang Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMetang();
                }
                return _instance;
            }
        }

		public SpecieMetang() : base(
			"Metang",
			60, // HPs
			75, 100, // Attack & Defense
			55, 80, // Special Attack & Defense
			50			
		) {}
	}


	//Metang Pokemon Class
	public class Metang : Pokemon
	{

		public Metang(string nickname, int level)
		: base(
				375,
				SpecieMetang.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Metang(int level)
		: base(
				375,
				SpecieMetang.Instance, // Pokemon Specie
				"Metang", level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Metang() : base(
			375,
			SpecieMetang.Instance, // Pokemon Specie
			Steel.Instance, Psychic.Instance			
		) {}
	}
}