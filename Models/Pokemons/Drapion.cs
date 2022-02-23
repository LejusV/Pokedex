using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Drapion Specie to store common natural stats of every {'abilities': ['battle-armor', 'sniper', 'keen-eye'], 'base_experience': 175, 'height': 13, 'id': 452, 'moves': ['swords-dance', 'cut', 'headbutt', 'poison-sting', 'pin-missile', 'leer', 'bite', 'roar', 'hyper-beam', 'strength', 'earthquake', 'dig', 'toxic', 'double-team', 'flash', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'protect', 'scary-face', 'sludge-bomb', 'mud-slap', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'shadow-ball', 'rock-smash', 'torment', 'facade', 'taunt', 'brick-break', 'knock-off', 'secret-power', 'poison-fang', 'rock-tomb', 'aerial-ace', 'natural-gift', 'acupressure', 'payback', 'fling', 'toxic-spikes', 'poison-jab', 'dark-pulse', 'night-slash', 'aqua-tail', 'x-scissor', 'giga-impact', 'thunder-fang', 'ice-fang', 'fire-fang', 'rock-climb', 'cross-poison', 'captivate', 'bug-bite', 'hone-claws', 'venoshock', 'round', 'retaliate', 'struggle-bug', 'bulldoze', 'snarl', 'fell-stinger', 'confide', 'infestation', 'brutal-swing'], 'name': 'drapion', 'stats': {'hp': 70, 'attack': 90, 'defense': 110, 'special-attack': 60, 'special-defense': 75, 'speed': 95}, 'types': ['poison', 'dark'], 'weight': 615, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'purple', 'shape': 'armor', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['bug', 'water3'], 'names': {'ja-Hrkt': 'ドラピオン', 'roomaji': 'Dorapion', 'ko': '드래피온', 'zh-Hant': '龍王蠍', 'fr': 'Drascore', 'de': 'Piondragi', 'es': 'Drapion', 'it': 'Drapion', 'en': 'Drapion', 'ja': 'ドラピオン', 'zh-Hans': '龙王蝎'}, 'genera': {'ja-Hrkt': 'ばけさそりポケモン', 'ko': '요괴전갈포켓몬', 'zh-Hant': '蠍怪寶可夢', 'fr': 'Pokémon Scorpogre', 'de': 'Ogerskorpion', 'es': 'Pokémon Escorpiogro', 'it': 'Pokémon Scorpiaccio', 'en': 'Ogre Scorpion Pokémon', 'ja': 'ばけさそりポケモン', 'zh-Hans': '蝎怪宝可梦'}}
	public class SpecieDrapion : PokemonSpecie
	{
#nullable enable
		private static SpecieDrapion? _instance = null;
#nullable restore
        public static SpecieDrapion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDrapion();
                }
                return _instance;
            }
        }

		public SpecieDrapion() : base(
			"Drapion",
			70, // HPs
			90, 110, // Attack & Defense
			60, 75, // Special Attack & Defense
			95			
		) {}
	}


	//Drapion Pokemon Class
	public class Drapion : Pokemon
	{

		public Drapion(string nickname, int level) : base(
			452,
			SpecieDrapion.Instance, // Pokemon Specie
			nickname, level,
			Poison.Instance, Dark.Instance			
		) {}

		public Drapion() : base(
			452,
			SpecieDrapion.Instance, // Pokemon Specie
			Poison.Instance, Dark.Instance			
		) {}
	}
}