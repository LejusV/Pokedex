using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Garchomp Specie to store common natural stats of every {'abilities': ['sand-veil', 'rough-skin'], 'base_experience': 270, 'height': 19, 'id': 445, 'moves': ['swords-dance', 'cut', 'sand-attack', 'headbutt', 'tackle', 'take-down', 'roar', 'flamethrower', 'surf', 'hyper-beam', 'strength', 'dragon-rage', 'earthquake', 'dig', 'toxic', 'double-team', 'fire-blast', 'swift', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'protect', 'mud-slap', 'outrage', 'sandstorm', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'crunch', 'rock-smash', 'whirlpool', 'facade', 'brick-break', 'secret-power', 'rock-tomb', 'sand-tomb', 'aerial-ace', 'dragon-claw', 'natural-gift', 'fling', 'poison-jab', 'aqua-tail', 'dragon-pulse', 'dragon-rush', 'earth-power', 'giga-impact', 'shadow-claw', 'fire-fang', 'rock-climb', 'draco-meteor', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'hone-claws', 'round', 'incinerate', 'bulldoze', 'dragon-tail', 'dual-chop', 'confide', 'brutal-swing'], 'name': 'garchomp', 'stats': {'hp': 108, 'attack': 130, 'defense': 95, 'special-attack': 80, 'special-defense': 85, 'speed': 102}, 'types': ['dragon', 'ground'], 'weight': 950, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['monster', 'dragon'], 'names': {'ja-Hrkt': 'ガブリアス', 'roomaji': 'Gablias', 'ko': '한카리아스', 'zh-Hant': '烈咬陸鯊', 'fr': 'Carchacrok', 'de': 'Knakrack', 'es': 'Garchomp', 'it': 'Garchomp', 'en': 'Garchomp', 'ja': 'ガブリアス', 'zh-Hans': '烈咬陆鲨'}, 'genera': {'ja-Hrkt': 'マッハポケモン', 'ko': '마하포켓몬', 'zh-Hant': '音速寶可夢', 'fr': 'Pokémon Supersonic', 'de': 'Rasanz', 'es': 'Pokémon Mach', 'it': 'Pokémon Mach', 'en': 'Mach Pokémon', 'ja': 'マッハポケモン', 'zh-Hans': '音速宝可梦'}}
	public class SpecieGarchomp : PokemonSpecie
	{
#nullable enable
		private static SpecieGarchomp? _instance = null;
#nullable restore
        public static SpecieGarchomp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGarchomp();
                }
                return _instance;
            }
        }

		public SpecieGarchomp() : base(
			"Garchomp",
			108, // HPs
			130, 95, // Attack & Defense
			80, 85, // Special Attack & Defense
			102			
		) {}
	}


	//Garchomp Pokemon Class
	public class Garchomp : Pokemon
	{

		public Garchomp(string nickname, int level) : base(
			445,
			SpecieGarchomp.Instance, // Pokemon Specie
			nickname, level,
			Dragon.Instance, Ground.Instance			
		) {}

		public Garchomp() : base(
			445,
			SpecieGarchomp.Instance, // Pokemon Specie
			Dragon.Instance, Ground.Instance			
		) {}
	}
}