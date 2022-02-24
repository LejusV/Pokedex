using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Slaking Specie to store common natural stats of every {'abilities': ['truant'], 'base_experience': 252, 'height': 20, 'id': 289, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'scratch', 'cut', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'roar', 'flamethrower', 'ice-beam', 'blizzard', 'hyper-beam', 'low-kick', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'thunderbolt', 'thunder', 'earthquake', 'toxic', 'mimic', 'double-team', 'fire-blast', 'amnesia', 'rest', 'rock-slide', 'substitute', 'snore', 'flail', 'protect', 'feint-attack', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'encore', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'facade', 'focus-punch', 'taunt', 'brick-break', 'yawn', 'secret-power', 'slack-off', 'rock-tomb', 'aerial-ace', 'block', 'bulk-up', 'covet', 'shock-wave', 'water-pulse', 'hammer-arm', 'natural-gift', 'fling', 'punishment', 'sucker-punch', 'focus-blast', 'giga-impact', 'shadow-claw', 'rock-climb', 'gunk-shot', 'captivate', 'hone-claws', 'smack-down', 'low-sweep', 'after-you', 'round', 'chip-away', 'incinerate', 'quash', 'retaliate', 'bulldoze', 'work-up', 'confide', 'power-up-punch'], 'name': 'slaking', 'stats': {'hp': 150, 'attack': 160, 'defense': 100, 'special-attack': 95, 'special-defense': 65, 'speed': 100}, 'types': ['normal'], 'weight': 1305, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'brown', 'shape': 'humanoid', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ケッキング', 'roomaji': 'Kekking', 'ko': '게을킹', 'zh-Hant': '請假王', 'fr': 'Monaflèmit', 'de': 'Letarking', 'es': 'Slaking', 'it': 'Slaking', 'en': 'Slaking', 'ja': 'ケッキング', 'zh-Hans': '请假王'}, 'genera': {'ja-Hrkt': 'ものぐさポケモン', 'ko': '나태함포켓몬', 'zh-Hant': '怕麻煩寶可夢', 'fr': 'Pokémon Fainéant', 'de': 'Müßig', 'es': 'Pokémon Holgazán', 'it': 'Pokémon Pigrizia', 'en': 'Lazy Pokémon', 'ja': 'ものぐさポケモン', 'zh-Hans': '怕麻烦宝可梦'}}
	public class SpecieSlaking : PokemonSpecie
	{
#nullable enable
		private static SpecieSlaking? _instance = null;
#nullable restore
        public static SpecieSlaking Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSlaking();
                }
                return _instance;
            }
        }

		public SpecieSlaking() : base(
			"Slaking",
			150, // HPs
			160, 100, // Attack & Defense
			95, 65, // Special Attack & Defense
			100			
		) {}
	}


	//Slaking Pokemon Class
	public class Slaking : Pokemon
	{

		public Slaking(string nickname, int level)
		: base(
				289,
				SpecieSlaking.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Slaking() : base(
			289,
			SpecieSlaking.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}