using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Flareon Specie to store common natural stats of every {'abilities': ['flash-fire', 'guts'], 'base_experience': 184, 'height': 9, 'id': 136, 'moves': ['sand-attack', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'leer', 'bite', 'roar', 'ember', 'flamethrower', 'hyper-beam', 'strength', 'fire-spin', 'dig', 'toxic', 'quick-attack', 'rage', 'mimic', 'double-team', 'reflect', 'bide', 'smog', 'fire-blast', 'swift', 'skull-bash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'scary-face', 'mud-slap', 'zap-cannon', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'heat-wave', 'will-o-wisp', 'facade', 'helping-hand', 'superpower', 'secret-power', 'hyper-voice', 'overheat', 'covet', 'natural-gift', 'last-resort', 'flare-blitz', 'giga-impact', 'fire-fang', 'lava-plume', 'captivate', 'flame-charge', 'round', 'echoed-voice', 'incinerate', 'retaliate', 'work-up', 'confide', 'baby-doll-eyes'], 'name': 'flareon', 'stats': {'hp': 65, 'attack': 130, 'defense': 60, 'special-attack': 95, 'special-defense': 110, 'speed': 65}, 'types': ['fire'], 'weight': 250, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 35, 'gender_rate': 1, 'capture_rate': 45, 'color': 'red', 'shape': 'quadruped', 'habitat': 'urban', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ブースター', 'roomaji': 'Booster', 'ko': '부스터', 'zh-Hant': '火伊布', 'fr': 'Pyroli', 'de': 'Flamara', 'es': 'Flareon', 'it': 'Flareon', 'en': 'Flareon', 'ja': 'ブースター', 'zh-Hans': '火伊布'}, 'genera': {'ja-Hrkt': 'ほのおポケモン', 'ko': '불꽃포켓몬', 'zh-Hant': '火寶可夢', 'fr': 'Pokémon Flamme', 'de': 'Feuer', 'es': 'Pokémon Llama', 'it': 'Pokémon Fiamma', 'en': 'Flame Pokémon', 'ja': 'ほのおポケモン', 'zh-Hans': '火宝可梦'}}
	public class SpecieFlareon : PokemonSpecie
	{
#nullable enable
		private static SpecieFlareon? _instance = null;
#nullable restore
        public static SpecieFlareon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFlareon();
                }
                return _instance;
            }
        }

		public SpecieFlareon() : base(
			"Flareon",
			65, // HPs
			130, 60, // Attack & Defense
			95, 110, // Special Attack & Defense
			65			
		) {}
	}


	//Flareon Pokemon Class
	public class Flareon : Pokemon
	{

		public Flareon(string nickname, int level) : base(
			136,
			SpecieFlareon.Instance, // Pokemon Specie
			nickname, level,
			Fire.Instance			
		) {}

		public Flareon() : base(
			136,
			SpecieFlareon.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}