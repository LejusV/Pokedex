using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gligar Specie to store common natural stats of every {'abilities': ['hyper-cutter', 'sand-veil', 'immunity'], 'base_experience': 86, 'height': 11, 'id': 207, 'moves': ['guillotine', 'razor-wind', 'swords-dance', 'cut', 'wing-attack', 'sand-attack', 'headbutt', 'double-edge', 'poison-sting', 'counter', 'strength', 'earthquake', 'dig', 'toxic', 'agility', 'quick-attack', 'mimic', 'screech', 'double-team', 'harden', 'swift', 'dream-eater', 'rest', 'rock-slide', 'slash', 'substitute', 'thief', 'snore', 'curse', 'protect', 'feint-attack', 'sludge-bomb', 'detect', 'sandstorm', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'baton-pass', 'iron-tail', 'metal-claw', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'torment', 'facade', 'taunt', 'brick-break', 'knock-off', 'secret-power', 'rock-tomb', 'sky-uppercut', 'sand-tomb', 'aerial-ace', 'poison-tail', 'roost', 'natural-gift', 'feint', 'tailwind', 'u-turn', 'payback', 'fling', 'power-trick', 'rock-polish', 'poison-jab', 'dark-pulse', 'night-slash', 'aqua-tail', 'x-scissor', 'earth-power', 'rock-climb', 'defog', 'cross-poison', 'stone-edge', 'captivate', 'stealth-rock', 'bug-bite', 'hone-claws', 'venoshock', 'round', 'acrobatics', 'struggle-bug', 'bulldoze', 'confide'], 'name': 'gligar', 'stats': {'hp': 65, 'attack': 75, 'defense': 105, 'special-attack': 35, 'special-defense': 65, 'speed': 85}, 'types': ['ground', 'flying'], 'weight': 648, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'purple', 'shape': 'wings', 'habitat': 'mountain', 'generation': 'generation-ii', 'growth_rate': 'medium-slow', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'グライガー', 'roomaji': 'Gliger', 'ko': '글라이거', 'zh-Hant': '天蠍', 'fr': 'Scorplane', 'de': 'Skorgla', 'es': 'Gligar', 'it': 'Gligar', 'en': 'Gligar', 'ja': 'グライガー', 'zh-Hans': '天蝎'}, 'genera': {'ja-Hrkt': 'とびさそりポケモン', 'ko': '날전갈포켓몬', 'zh-Hant': '飛蠍寶可夢', 'fr': 'Pokémon Scorpivol', 'de': 'Flugskorpi', 'es': 'Pokémon Escorpiala', 'it': 'Pokémon Aliscorpio', 'en': 'Fly Scorpion Pokémon', 'ja': 'とびさそりポケモン', 'zh-Hans': '飞蝎宝可梦'}}
	public class SpecieGligar : PokemonSpecie
	{
#nullable enable
		private static SpecieGligar? _instance = null;
#nullable restore
        public static SpecieGligar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGligar();
                }
                return _instance;
            }
        }

		public SpecieGligar() : base(
			"Gligar",
			65, // HPs
			75, 105, // Attack & Defense
			35, 65, // Special Attack & Defense
			85			
		) {}
	}


	//Gligar Pokemon Class
	public class Gligar : Pokemon
	{

		public Gligar(string nickname, int level) : base(
			207,
			SpecieGligar.Instance, // Pokemon Specie
			nickname, level,
			Ground.Instance, Flying.Instance			
		) {}

		public Gligar() : base(
			207,
			SpecieGligar.Instance, // Pokemon Specie
			Ground.Instance, Flying.Instance			
		) {}
	}
}