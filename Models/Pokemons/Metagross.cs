using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Metagross Specie to store common natural stats of every {'abilities': ['clear-body', 'light-metal'], 'base_experience': 270, 'height': 16, 'id': 376, 'moves': ['ice-punch', 'thunder-punch', 'cut', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'hyper-beam', 'strength', 'earthquake', 'toxic', 'confusion', 'psychic', 'agility', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'reflect', 'self-destruct', 'swift', 'flash', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'scary-face', 'sludge-bomb', 'mud-slap', 'icy-wind', 'sandstorm', 'endure', 'rollout', 'swagger', 'fury-cutter', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'pursuit', 'metal-claw', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'facade', 'trick', 'brick-break', 'secret-power', 'meteor-mash', 'rock-tomb', 'signal-beam', 'aerial-ace', 'iron-defense', 'block', 'gravity', 'miracle-eye', 'hammer-arm', 'gyro-ball', 'natural-gift', 'magnet-rise', 'rock-polish', 'giga-impact', 'bullet-punch', 'zen-headbutt', 'flash-cannon', 'iron-head', 'stealth-rock', 'grass-knot', 'hone-claws', 'psyshock', 'telekinesis', 'round', 'bulldoze', 'confide', 'power-up-punch'], 'name': 'metagross', 'stats': {'hp': 80, 'attack': 135, 'defense': 130, 'special-attack': 95, 'special-defense': 90, 'speed': 70}, 'types': ['steel', 'psychic'], 'weight': 5500, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': -1, 'capture_rate': 3, 'color': 'blue', 'shape': 'heads', 'habitat': 'rough-terrain', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'メタグロス', 'roomaji': 'Metagross', 'ko': '메타그로스', 'zh-Hant': '巨金怪', 'fr': 'Métalosse', 'de': 'Metagross', 'es': 'Metagross', 'it': 'Metagross', 'en': 'Metagross', 'ja': 'メタグロス', 'zh-Hans': '巨金怪'}, 'genera': {'ja-Hrkt': 'てつあしポケモン', 'ko': '무쇠다리포켓몬', 'zh-Hant': '鐵足寶可夢', 'fr': 'Pokémon Pattefer', 'de': 'Eisenfuß', 'es': 'Pokémon Pata Hierro', 'it': 'Pokémon Ferrarto', 'en': 'Iron Leg Pokémon', 'ja': 'てつあしポケモン', 'zh-Hans': '铁足宝可梦'}}
	public class SpecieMetagross : PokemonSpecie
	{
#nullable enable
		private static SpecieMetagross? _instance = null;
#nullable restore
        public static SpecieMetagross Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMetagross();
                }
                return _instance;
            }
        }

		public SpecieMetagross() : base(
			"Metagross",
			80, // HPs
			135, 130, // Attack & Defense
			95, 90, // Special Attack & Defense
			70			
		) {}
	}


	//Metagross Pokemon Class
	public class Metagross : Pokemon
	{

		public Metagross(string nickname, int level)
		: base(
				376,
				SpecieMetagross.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Metagross() : base(
			376,
			SpecieMetagross.Instance, // Pokemon Specie
			Steel.Instance, Psychic.Instance			
		) {}
	}
}