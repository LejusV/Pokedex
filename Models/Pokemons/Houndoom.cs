using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Houndoom Specie to store common natural stats of every {'abilities': ['early-bird', 'flash-fire', 'unnerve'], 'base_experience': 175, 'height': 14, 'id': 229, 'moves': ['headbutt', 'body-slam', 'double-edge', 'leer', 'bite', 'roar', 'ember', 'flamethrower', 'hyper-beam', 'counter', 'strength', 'solar-beam', 'toxic', 'mimic', 'double-team', 'smog', 'fire-blast', 'swift', 'dream-eater', 'rest', 'super-fang', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'spite', 'protect', 'feint-attack', 'sludge-bomb', 'mud-slap', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'sunny-day', 'crunch', 'shadow-ball', 'rock-smash', 'beat-up', 'uproar', 'heat-wave', 'torment', 'will-o-wisp', 'facade', 'taunt', 'role-play', 'snatch', 'secret-power', 'hyper-voice', 'overheat', 'odor-sleuth', 'howl', 'natural-gift', 'payback', 'embargo', 'sucker-punch', 'dark-pulse', 'giga-impact', 'nasty-plot', 'thunder-fang', 'fire-fang', 'captivate', 'flame-charge', 'foul-play', 'round', 'incinerate', 'retaliate', 'inferno', 'snarl', 'confide'], 'name': 'houndoom', 'stats': {'hp': 75, 'attack': 90, 'defense': 50, 'special-attack': 110, 'special-defense': 80, 'speed': 95}, 'types': ['dark', 'fire'], 'weight': 350, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'black', 'shape': 'quadruped', 'habitat': 'rough-terrain', 'generation': 'generation-ii', 'growth_rate': 'slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ヘルガー', 'roomaji': 'Hellgar', 'ko': '헬가', 'zh-Hant': '黑魯加', 'fr': 'Démolosse', 'de': 'Hundemon', 'es': 'Houndoom', 'it': 'Houndoom', 'en': 'Houndoom', 'ja': 'ヘルガー', 'zh-Hans': '黑鲁加'}, 'genera': {'ja-Hrkt': 'ダークポケモン', 'ko': '다크포켓몬', 'zh-Hant': '陰暗寶可夢', 'fr': 'Pokémon Sombre', 'de': 'Hades', 'es': 'Pokémon Siniestro', 'it': 'Pokémon Buio', 'en': 'Dark Pokémon', 'ja': 'ダークポケモン', 'zh-Hans': '阴暗宝可梦'}}
	public class SpecieHoundoom : PokemonSpecie
	{
#nullable enable
		private static SpecieHoundoom? _instance = null;
#nullable restore
        public static SpecieHoundoom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHoundoom();
                }
                return _instance;
            }
        }

		public SpecieHoundoom() : base(
			"Houndoom",
			75, // HPs
			90, 50, // Attack & Defense
			110, 80, // Special Attack & Defense
			95			
		) {}
	}


	//Houndoom Pokemon Class
	public class Houndoom : Pokemon
	{

		public Houndoom(string nickname, int level)
		: base(
				229,
				SpecieHoundoom.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Houndoom() : base(
			229,
			SpecieHoundoom.Instance, // Pokemon Specie
			Dark.Instance, Fire.Instance			
		) {}
	}
}