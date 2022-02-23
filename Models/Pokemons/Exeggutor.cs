using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Exeggutor Specie to store common natural stats of every {'abilities': ['chlorophyll', 'harvest'], 'base_experience': 186, 'height': 20, 'id': 103, 'moves': ['swords-dance', 'stomp', 'headbutt', 'take-down', 'double-edge', 'hyper-beam', 'low-kick', 'strength', 'mega-drain', 'solar-beam', 'toxic', 'confusion', 'psychic', 'hypnosis', 'rage', 'teleport', 'mimic', 'double-team', 'light-screen', 'reflect', 'bide', 'self-destruct', 'egg-bomb', 'dream-eater', 'barrage', 'flash', 'psywave', 'explosion', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'protect', 'sludge-bomb', 'giga-drain', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'synthesis', 'hidden-power', 'sunny-day', 'psych-up', 'ancient-power', 'facade', 'nature-power', 'skill-swap', 'secret-power', 'bullet-seed', 'block', 'gravity', 'natural-gift', 'worry-seed', 'seed-bomb', 'energy-ball', 'giga-impact', 'zen-headbutt', 'trick-room', 'leaf-storm', 'captivate', 'grass-knot', 'wood-hammer', 'psyshock', 'telekinesis', 'round', 'confide', 'infestation'], 'name': 'exeggutor', 'stats': {'hp': 95, 'attack': 95, 'defense': 85, 'special-attack': 125, 'special-defense': 75, 'speed': 55}, 'types': ['grass', 'psychic'], 'weight': 1200, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'yellow', 'shape': 'legs', 'habitat': 'forest', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'ナッシー', 'roomaji': 'Nassy', 'ko': '나시', 'zh-Hant': '椰蛋樹', 'fr': 'Noadkoko', 'de': 'Kokowei', 'es': 'Exeggutor', 'it': 'Exeggutor', 'en': 'Exeggutor', 'ja': 'ナッシー', 'zh-Hans': '椰蛋树'}, 'genera': {'ja-Hrkt': 'やしのみポケモン', 'ko': '야자열매포켓몬', 'zh-Hant': '椰子寶可夢', 'fr': 'Pokémon Fruitpalme', 'de': 'Palmfrucht', 'es': 'Pokémon Coco', 'it': 'Pokémon Nocecocco', 'en': 'Coconut Pokémon', 'ja': 'やしのみポケモン', 'zh-Hans': '椰子宝可梦'}}
	public class SpecieExeggutor : PokemonSpecie
	{
#nullable enable
		private static SpecieExeggutor? _instance = null;
#nullable restore
        public static SpecieExeggutor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieExeggutor();
                }
                return _instance;
            }
        }

		public SpecieExeggutor() : base(
			"Exeggutor",
			95, // HPs
			95, 85, // Attack & Defense
			125, 75, // Special Attack & Defense
			55			
		) {}
	}


	//Exeggutor Pokemon Class
	public class Exeggutor : Pokemon
	{

		public Exeggutor(string nickname, int level) : base(
			103,
			SpecieExeggutor.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance, Psychic.Instance			
		) {}

		public Exeggutor() : base(
			103,
			SpecieExeggutor.Instance, // Pokemon Specie
			Grass.Instance, Psychic.Instance			
		) {}
	}
}