using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Leavanny Specie to store common natural stats of every {'abilities': ['swarm', 'chlorophyll', 'overcoat'], 'base_experience': 225, 'height': 12, 'id': 542, 'moves': ['swords-dance', 'cut', 'tackle', 'hyper-beam', 'razor-leaf', 'solar-beam', 'string-shot', 'toxic', 'double-team', 'light-screen', 'reflect', 'dream-eater', 'flash', 'rest', 'slash', 'substitute', 'snore', 'protect', 'giga-drain', 'false-swipe', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'synthesis', 'hidden-power', 'sunny-day', 'facade', 'nature-power', 'helping-hand', 'magic-coat', 'knock-off', 'secret-power', 'signal-beam', 'aerial-ace', 'iron-defense', 'calm-mind', 'leaf-blade', 'payback', 'worry-seed', 'poison-jab', 'seed-bomb', 'x-scissor', 'energy-ball', 'giga-impact', 'shadow-claw', 'leaf-storm', 'grass-knot', 'bug-bite', 'hone-claws', 'entrainment', 'round', 'retaliate', 'struggle-bug', 'electroweb', 'fell-stinger', 'confide'], 'name': 'leavanny', 'stats': {'hp': 75, 'attack': 103, 'defense': 80, 'special-attack': 70, 'special-defense': 80, 'speed': 92}, 'types': ['bug', 'grass'], 'weight': 205, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'yellow', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'ハハコモリ', 'ko': '모아머', 'zh-Hant': '保母蟲', 'fr': 'Manternel', 'de': 'Matrifol', 'es': 'Leavanny', 'it': 'Leavanny', 'en': 'Leavanny', 'ja': 'ハハコモリ', 'zh-Hans': '保姆虫'}, 'genera': {'ja-Hrkt': 'こそだてポケモン', 'ko': '육아포켓몬', 'zh-Hant': '育兒寶可夢', 'fr': 'Pokémon Précepteur', 'de': 'Kinderpflege', 'es': 'Pokémon Cuidador', 'it': 'Pokémon Balia', 'en': 'Nurturing Pokémon', 'ja': 'こそだてポケモン', 'zh-Hans': '育儿宝可梦'}}
	public class SpecieLeavanny : PokemonSpecie
	{
#nullable enable
		private static SpecieLeavanny? _instance = null;
#nullable restore
        public static SpecieLeavanny Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLeavanny();
                }
                return _instance;
            }
        }

		public SpecieLeavanny() : base(
			"Leavanny",
			75, // HPs
			103, 80, // Attack & Defense
			70, 80, // Special Attack & Defense
			92			
		) {}
	}


	//Leavanny Pokemon Class
	public class Leavanny : Pokemon
	{

		public Leavanny(string nickname, int level) : base(
			542,
			SpecieLeavanny.Instance, // Pokemon Specie
			nickname, level,
			Bug.Instance, Grass.Instance			
		) {}

		public Leavanny() : base(
			542,
			SpecieLeavanny.Instance, // Pokemon Specie
			Bug.Instance, Grass.Instance			
		) {}
	}
}