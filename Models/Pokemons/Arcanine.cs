using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Arcanine Specie to store common natural stats of every {'abilities': ['intimidate', 'flash-fire', 'justified'], 'base_experience': 194, 'height': 19, 'id': 59, 'moves': ['headbutt', 'body-slam', 'take-down', 'double-edge', 'leer', 'bite', 'roar', 'ember', 'flamethrower', 'hyper-beam', 'strength', 'solar-beam', 'dragon-rage', 'dig', 'toxic', 'rage', 'teleport', 'mimic', 'double-team', 'reflect', 'bide', 'fire-blast', 'swift', 'skull-bash', 'rest', 'substitute', 'thief', 'flame-wheel', 'snore', 'curse', 'protect', 'mud-slap', 'outrage', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dragon-breath', 'iron-tail', 'hidden-power', 'sunny-day', 'extreme-speed', 'rock-smash', 'heat-wave', 'will-o-wisp', 'facade', 'helping-hand', 'secret-power', 'overheat', 'odor-sleuth', 'aerial-ace', 'covet', 'natural-gift', 'dragon-pulse', 'giga-impact', 'thunder-fang', 'fire-fang', 'rock-climb', 'iron-head', 'captivate', 'flame-charge', 'round', 'incinerate', 'retaliate', 'bulldoze', 'wild-charge', 'snarl', 'confide'], 'name': 'arcanine', 'stats': {'hp': 90, 'attack': 110, 'defense': 80, 'special-attack': 100, 'special-defense': 80, 'speed': 95}, 'types': ['fire'], 'weight': 1550, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 2, 'capture_rate': 75, 'color': 'brown', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ウインディ', 'roomaji': 'Windie', 'ko': '윈디', 'zh-Hant': '風速狗', 'fr': 'Arcanin', 'de': 'Arkani', 'es': 'Arcanine', 'it': 'Arcanine', 'en': 'Arcanine', 'ja': 'ウインディ', 'zh-Hans': '风速狗'}, 'genera': {'ja-Hrkt': 'でんせつポケモン', 'ko': '전설포켓몬', 'zh-Hant': '傳說寶可夢', 'fr': 'Pokémon Légendaire', 'de': 'Legendär', 'es': 'Pokémon Legendario', 'it': 'Pokémon Leggenda', 'en': 'Legendary Pokémon', 'ja': 'でんせつポケモン', 'zh-Hans': '传说宝可梦'}}
	public class SpecieArcanine : PokemonSpecie
	{
#nullable enable
		private static SpecieArcanine? _instance = null;
#nullable restore
        public static SpecieArcanine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieArcanine();
                }
                return _instance;
            }
        }

		public SpecieArcanine() : base(
			"Arcanine",
			90, // HPs
			110, 80, // Attack & Defense
			100, 80, // Special Attack & Defense
			95			
		) {}
	}


	//Arcanine Pokemon Class
	public class Arcanine : Pokemon
	{

		public Arcanine(string nickname, int level)
		: base(
				59,
				SpecieArcanine.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Arcanine() : base(
			59,
			SpecieArcanine.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}