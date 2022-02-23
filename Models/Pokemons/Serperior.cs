using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Serperior Specie to store common natural stats of every {'abilities': ['overgrow', 'contrary'], 'base_experience': 238, 'height': 33, 'id': 497, 'moves': ['swords-dance', 'cut', 'bind', 'slam', 'vine-whip', 'tackle', 'wrap', 'leer', 'hyper-beam', 'strength', 'mega-drain', 'leech-seed', 'growth', 'solar-beam', 'toxic', 'double-team', 'light-screen', 'reflect', 'flash', 'rest', 'substitute', 'snore', 'protect', 'outrage', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'iron-tail', 'synthesis', 'hidden-power', 'sunny-day', 'rock-smash', 'torment', 'facade', 'nature-power', 'taunt', 'knock-off', 'snatch', 'secret-power', 'aerial-ace', 'frenzy-plant', 'calm-mind', 'leaf-blade', 'wring-out', 'gastro-acid', 'worry-seed', 'aqua-tail', 'seed-bomb', 'dragon-pulse', 'energy-ball', 'giga-impact', 'leaf-storm', 'grass-knot', 'coil', 'round', 'grass-pledge', 'dragon-tail', 'work-up', 'leaf-tornado', 'confide', 'brutal-swing'], 'name': 'serperior', 'stats': {'hp': 75, 'attack': 75, 'defense': 95, 'special-attack': 75, 'special-defense': 95, 'speed': 113}, 'types': ['grass'], 'weight': 630, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'green', 'shape': 'squiggle', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['ground', 'plant'], 'names': {'ja-Hrkt': 'ジャローダ', 'ko': '샤로다', 'zh-Hant': '君主蛇', 'fr': 'Majaspic', 'de': 'Serpiroyal', 'es': 'Serperior', 'it': 'Serperior', 'en': 'Serperior', 'ja': 'ジャローダ', 'zh-Hans': '君主蛇'}, 'genera': {'ja-Hrkt': 'ロイヤルポケモン', 'ko': '로열포켓몬', 'zh-Hant': '皇家寶可夢', 'fr': 'Pokémon Majestueux', 'de': 'Hoheit', 'es': 'Pokémon Realeza', 'it': 'Pokémon Regale', 'en': 'Regal Pokémon', 'ja': 'ロイヤルポケモン', 'zh-Hans': '皇家宝可梦'}}
	public class SpecieSerperior : PokemonSpecie
	{
#nullable enable
		private static SpecieSerperior? _instance = null;
#nullable restore
        public static SpecieSerperior Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSerperior();
                }
                return _instance;
            }
        }

		public SpecieSerperior() : base(
			"Serperior",
			75, // HPs
			75, 95, // Attack & Defense
			75, 95, // Special Attack & Defense
			113			
		) {}
	}


	//Serperior Pokemon Class
	public class Serperior : Pokemon
	{

		public Serperior(string nickname, int level) : base(
			497,
			SpecieSerperior.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance			
		) {}

		public Serperior() : base(
			497,
			SpecieSerperior.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}