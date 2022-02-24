using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Charmander Specie to store common natural stats of every {'abilities': ['blaze', 'solar-power'], 'base_experience': 62, 'height': 6, 'id': 4, 'moves': ['mega-punch', 'fire-punch', 'thunder-punch', 'scratch', 'swords-dance', 'cut', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'leer', 'bite', 'growl', 'ember', 'flamethrower', 'submission', 'counter', 'seismic-toss', 'strength', 'dragon-rage', 'fire-spin', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'smokescreen', 'defense-curl', 'reflect', 'bide', 'fire-blast', 'swift', 'skull-bash', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'curse', 'protect', 'scary-face', 'belly-drum', 'mud-slap', 'outrage', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'dragon-breath', 'iron-tail', 'metal-claw', 'hidden-power', 'sunny-day', 'crunch', 'ancient-power', 'rock-smash', 'beat-up', 'heat-wave', 'will-o-wisp', 'facade', 'focus-punch', 'brick-break', 'secret-power', 'air-cutter', 'overheat', 'rock-tomb', 'aerial-ace', 'dragon-claw', 'dragon-dance', 'natural-gift', 'fling', 'flare-blitz', 'dragon-pulse', 'dragon-rush', 'shadow-claw', 'fire-fang', 'captivate', 'hone-claws', 'flame-burst', 'flame-charge', 'round', 'echoed-voice', 'incinerate', 'inferno', 'fire-pledge', 'work-up', 'confide', 'power-up-punch'], 'name': 'charmander', 'stats': {'hp': 39, 'attack': 52, 'defense': 43, 'special-attack': 60, 'special-defense': 50, 'speed': 65}, 'types': ['fire'], 'weight': 85, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'red', 'shape': 'upright', 'habitat': 'mountain', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'dragon'], 'names': {'ja-Hrkt': 'ヒトカゲ', 'roomaji': 'Hitokage', 'ko': '파이리', 'zh-Hant': '小火龍', 'fr': 'Salamèche', 'de': 'Glumanda', 'es': 'Charmander', 'it': 'Charmander', 'en': 'Charmander', 'ja': 'ヒトカゲ', 'zh-Hans': '小火龙'}, 'genera': {'ja-Hrkt': 'とかげポケモン', 'ko': '도롱뇽포켓몬', 'zh-Hant': '蜥蜴寶可夢', 'fr': 'Pokémon Lézard', 'de': 'Echse', 'es': 'Pokémon Lagartija', 'it': 'Pokémon Lucertola', 'en': 'Lizard Pokémon', 'ja': 'とかげポケモン', 'zh-Hans': '蜥蜴宝可梦'}}
	public class SpecieCharmander : PokemonSpecie
	{
#nullable enable
		private static SpecieCharmander? _instance = null;
#nullable restore
        public static SpecieCharmander Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCharmander();
                }
                return _instance;
            }
        }

		public SpecieCharmander() : base(
			"Charmander",
			39, // HPs
			52, 43, // Attack & Defense
			60, 50, // Special Attack & Defense
			65			
		) {}
	}


	//Charmander Pokemon Class
	public class Charmander : Pokemon
	{

		public Charmander(string nickname, int level)
		: base(
				4,
				SpecieCharmander.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Charmander(int level)
		: base(
				4,
				SpecieCharmander.Instance, // Pokemon Specie
				"Charmander", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Charmander() : base(
			4,
			SpecieCharmander.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}