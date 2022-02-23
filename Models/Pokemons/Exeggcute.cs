using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Exeggcute Specie to store common natural stats of every {'abilities': ['chlorophyll', 'harvest'], 'base_experience': 65, 'height': 4, 'id': 102, 'moves': ['swords-dance', 'take-down', 'double-edge', 'strength', 'mega-drain', 'leech-seed', 'solar-beam', 'poison-powder', 'stun-spore', 'sleep-powder', 'toxic', 'confusion', 'psychic', 'hypnosis', 'rage', 'teleport', 'mimic', 'double-team', 'light-screen', 'reflect', 'bide', 'self-destruct', 'egg-bomb', 'dream-eater', 'barrage', 'flash', 'psywave', 'explosion', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'protect', 'sludge-bomb', 'giga-drain', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'synthesis', 'moonlight', 'hidden-power', 'sunny-day', 'psych-up', 'ancient-power', 'uproar', 'facade', 'nature-power', 'ingrain', 'skill-swap', 'secret-power', 'extrasensory', 'bullet-seed', 'block', 'gravity', 'natural-gift', 'lucky-chant', 'power-swap', 'worry-seed', 'seed-bomb', 'energy-ball', 'trick-room', 'leaf-storm', 'captivate', 'grass-knot', 'telekinesis', 'round', 'bestow', 'grassy-terrain', 'confide', 'infestation'], 'name': 'exeggcute', 'stats': {'hp': 60, 'attack': 40, 'defense': 80, 'special-attack': 60, 'special-defense': 45, 'speed': 40}, 'types': ['grass', 'psychic'], 'weight': 25, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 90, 'color': 'pink', 'shape': 'heads', 'habitat': 'forest', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'タマタマ', 'roomaji': 'Tamatama', 'ko': '아라리', 'zh-Hant': '蛋蛋', 'fr': 'Noeunoeuf', 'de': 'Owei', 'es': 'Exeggcute', 'it': 'Exeggcute', 'en': 'Exeggcute', 'ja': 'タマタマ', 'zh-Hans': '蛋蛋'}, 'genera': {'ja-Hrkt': 'たまごポケモン', 'ko': '알포켓몬', 'zh-Hant': '蛋寶可夢', 'fr': 'Pokémon Œuf', 'de': 'Ei', 'es': 'Pokémon Huevo', 'it': 'Pokémon Uovo', 'en': 'Egg Pokémon', 'ja': 'たまごポケモン', 'zh-Hans': '蛋宝可梦'}}
	public class SpecieExeggcute : PokemonSpecie
	{
#nullable enable
		private static SpecieExeggcute? _instance = null;
#nullable restore
        public static SpecieExeggcute Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieExeggcute();
                }
                return _instance;
            }
        }

		public SpecieExeggcute() : base(
			"Exeggcute",
			60, // HPs
			40, 80, // Attack & Defense
			60, 45, // Special Attack & Defense
			40			
		) {}
	}


	//Exeggcute Pokemon Class
	public class Exeggcute : Pokemon
	{

		public Exeggcute(string nickname, int level) : base(
			102,
			SpecieExeggcute.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance, Psychic.Instance			
		) {}

		public Exeggcute() : base(
			102,
			SpecieExeggcute.Instance, // Pokemon Specie
			Grass.Instance, Psychic.Instance			
		) {}
	}
}