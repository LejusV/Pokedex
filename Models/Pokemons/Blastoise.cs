using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Blastoise Specie to store common natural stats of every {'abilities': ['torrent', 'rain-dish'], 'base_experience': 239, 'height': 16, 'id': 9, 'moves': ['mega-punch', 'ice-punch', 'mega-kick', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'bite', 'roar', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'submission', 'counter', 'seismic-toss', 'strength', 'earthquake', 'fissure', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'withdraw', 'defense-curl', 'reflect', 'bide', 'waterfall', 'skull-bash', 'bubble', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'icy-wind', 'outrage', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'rapid-spin', 'iron-tail', 'hidden-power', 'rain-dance', 'rock-smash', 'whirlpool', 'hail', 'facade', 'focus-punch', 'brick-break', 'secret-power', 'dive', 'hydro-cannon', 'rock-tomb', 'signal-beam', 'iron-defense', 'water-pulse', 'gyro-ball', 'brine', 'natural-gift', 'fling', 'dark-pulse', 'aqua-tail', 'dragon-pulse', 'focus-blast', 'giga-impact', 'avalanche', 'zen-headbutt', 'flash-cannon', 'rock-climb', 'captivate', 'smack-down', 'round', 'scald', 'water-pledge', 'bulldoze', 'dragon-tail', 'work-up', 'confide', 'power-up-punch'], 'name': 'blastoise', 'stats': {'hp': 79, 'attack': 83, 'defense': 100, 'special-attack': 85, 'special-defense': 105, 'speed': 78}, 'types': ['water'], 'weight': 855, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': 'waters-edge', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'water1'], 'names': {'ja-Hrkt': 'カメックス', 'roomaji': 'Kamex', 'ko': '거북왕', 'zh-Hant': '水箭龜', 'fr': 'Tortank', 'de': 'Turtok', 'es': 'Blastoise', 'it': 'Blastoise', 'en': 'Blastoise', 'ja': 'カメックス', 'zh-Hans': '水箭龟'}, 'genera': {'ja-Hrkt': 'こうらポケモン', 'ko': '껍질포켓몬', 'zh-Hant': '甲殼寶可夢', 'fr': 'Pokémon Carapace', 'de': 'Panzertier', 'es': 'Pokémon Marisco', 'it': 'Pokémon Crostaceo', 'en': 'Shellfish Pokémon', 'ja': 'こうらポケモン', 'zh-Hans': '甲壳宝可梦'}}
	public class SpecieBlastoise : PokemonSpecie
	{
#nullable enable
		private static SpecieBlastoise? _instance = null;
#nullable restore
        public static SpecieBlastoise Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBlastoise();
                }
                return _instance;
            }
        }

		public SpecieBlastoise() : base(
			"Blastoise",
			79, // HPs
			83, 100, // Attack & Defense
			85, 105, // Special Attack & Defense
			78			
		) {}
	}


	//Blastoise Pokemon Class
	public class Blastoise : Pokemon
	{

		public Blastoise(string nickname, int level)
		: base(
				9,
				SpecieBlastoise.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Blastoise() : base(
			9,
			SpecieBlastoise.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}