using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Charmeleon Specie to store common natural stats of every {'abilities': ['blaze', 'solar-power'], 'base_experience': 142, 'height': 11, 'id': 5, 'moves': ['mega-punch', 'fire-punch', 'thunder-punch', 'scratch', 'swords-dance', 'cut', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'leer', 'growl', 'ember', 'flamethrower', 'submission', 'counter', 'seismic-toss', 'strength', 'dragon-rage', 'fire-spin', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'smokescreen', 'defense-curl', 'reflect', 'bide', 'fire-blast', 'swift', 'skull-bash', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'curse', 'protect', 'scary-face', 'mud-slap', 'outrage', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'dragon-breath', 'iron-tail', 'metal-claw', 'hidden-power', 'sunny-day', 'rock-smash', 'heat-wave', 'will-o-wisp', 'facade', 'focus-punch', 'brick-break', 'secret-power', 'overheat', 'rock-tomb', 'aerial-ace', 'dragon-claw', 'natural-gift', 'fling', 'dragon-pulse', 'shadow-claw', 'fire-fang', 'captivate', 'hone-claws', 'flame-burst', 'flame-charge', 'round', 'echoed-voice', 'incinerate', 'inferno', 'fire-pledge', 'work-up', 'confide', 'power-up-punch'], 'name': 'charmeleon', 'stats': {'hp': 58, 'attack': 64, 'defense': 58, 'special-attack': 80, 'special-defense': 65, 'speed': 80}, 'types': ['fire'], 'weight': 190, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'red', 'shape': 'upright', 'habitat': 'mountain', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'dragon'], 'names': {'ja-Hrkt': 'リザード', 'roomaji': 'Lizardo', 'ko': '리자드', 'zh-Hant': '火恐龍', 'fr': 'Reptincel', 'de': 'Glutexo', 'es': 'Charmeleon', 'it': 'Charmeleon', 'en': 'Charmeleon', 'ja': 'リザード', 'zh-Hans': '火恐龙'}, 'genera': {'ja-Hrkt': 'かえんポケモン', 'ko': '화염포켓몬', 'zh-Hant': '火焰寶可夢', 'fr': 'Pokémon Flamme', 'de': 'Flamme', 'es': 'Pokémon Llama', 'it': 'Pokémon Fiamma', 'en': 'Flame Pokémon', 'ja': 'かえんポケモン', 'zh-Hans': '火焰宝可梦'}}
	public class SpecieCharmeleon : PokemonSpecie
	{
#nullable enable
		private static SpecieCharmeleon? _instance = null;
#nullable restore
        public static SpecieCharmeleon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCharmeleon();
                }
                return _instance;
            }
        }

		public SpecieCharmeleon() : base(
			"Charmeleon",
			58, // HPs
			64, 58, // Attack & Defense
			80, 65, // Special Attack & Defense
			80			
		) {}
	}


	//Charmeleon Pokemon Class
	public class Charmeleon : Pokemon
	{

		public Charmeleon(string nickname, int level)
		: base(
				5,
				SpecieCharmeleon.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Charmeleon() : base(
			5,
			SpecieCharmeleon.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}