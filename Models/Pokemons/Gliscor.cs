using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gliscor Specie to store common natural stats of every {'abilities': ['hyper-cutter', 'sand-veil', 'poison-heal'], 'base_experience': 179, 'height': 20, 'id': 472, 'moves': ['guillotine', 'swords-dance', 'cut', 'sand-attack', 'headbutt', 'hyper-beam', 'strength', 'earthquake', 'dig', 'toxic', 'quick-attack', 'screech', 'double-team', 'harden', 'swift', 'sky-attack', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'protect', 'feint-attack', 'sludge-bomb', 'mud-slap', 'sandstorm', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'torment', 'facade', 'taunt', 'brick-break', 'knock-off', 'secret-power', 'rock-tomb', 'sky-uppercut', 'aerial-ace', 'roost', 'natural-gift', 'tailwind', 'u-turn', 'payback', 'fling', 'rock-polish', 'poison-jab', 'dark-pulse', 'night-slash', 'aqua-tail', 'x-scissor', 'earth-power', 'giga-impact', 'thunder-fang', 'ice-fang', 'fire-fang', 'defog', 'stone-edge', 'captivate', 'stealth-rock', 'bug-bite', 'hone-claws', 'venoshock', 'round', 'acrobatics', 'struggle-bug', 'bulldoze', 'confide', 'brutal-swing'], 'name': 'gliscor', 'stats': {'hp': 75, 'attack': 95, 'defense': 125, 'special-attack': 45, 'special-defense': 75, 'speed': 95}, 'types': ['ground', 'flying'], 'weight': 425, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 30, 'color': 'purple', 'shape': 'wings', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'グライオン', 'roomaji': 'Glion', 'ko': '글라이온', 'zh-Hant': '天蠍王', 'fr': 'Scorvol', 'de': 'Skorgro', 'es': 'Gliscor', 'it': 'Gliscor', 'en': 'Gliscor', 'ja': 'グライオン', 'zh-Hans': '天蝎王'}, 'genera': {'ja-Hrkt': 'キバさそりポケモン', 'ko': '송곳니전갈포켓몬', 'zh-Hant': '牙蠍寶可夢', 'fr': 'Pokémon Scorpicroc', 'de': 'Zahnskorpi', 'es': 'Pokémon Colmicorpio', 'it': 'Pokémon Scorpidente', 'en': 'Fang Scorpion Pokémon', 'ja': 'キバさそりポケモン', 'zh-Hans': '牙蝎宝可梦'}}
	public class SpecieGliscor : PokemonSpecie
	{
#nullable enable
		private static SpecieGliscor? _instance = null;
#nullable restore
        public static SpecieGliscor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGliscor();
                }
                return _instance;
            }
        }

		public SpecieGliscor() : base(
			"Gliscor",
			75, // HPs
			95, 125, // Attack & Defense
			45, 75, // Special Attack & Defense
			95			
		) {}
	}


	//Gliscor Pokemon Class
	public class Gliscor : Pokemon
	{

		public Gliscor(string nickname, int level) : base(
			472,
			SpecieGliscor.Instance, // Pokemon Specie
			nickname, level,
			Ground.Instance, Flying.Instance			
		) {}

		public Gliscor() : base(
			472,
			SpecieGliscor.Instance, // Pokemon Specie
			Ground.Instance, Flying.Instance			
		) {}
	}
}