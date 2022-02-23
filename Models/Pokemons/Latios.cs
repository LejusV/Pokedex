using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Latios Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 270, 'height': 20, 'id': 381, 'moves': ['cut', 'fly', 'body-slam', 'double-edge', 'roar', 'surf', 'ice-beam', 'hyper-beam', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'toxic', 'psychic', 'mimic', 'double-team', 'recover', 'light-screen', 'reflect', 'waterfall', 'swift', 'dream-eater', 'flash', 'psywave', 'rest', 'substitute', 'snore', 'protect', 'mud-slap', 'icy-wind', 'outrage', 'sandstorm', 'endure', 'swagger', 'fury-cutter', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dragon-breath', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'whirlpool', 'memento', 'facade', 'helping-hand', 'trick', 'magic-coat', 'refresh', 'secret-power', 'dive', 'luster-purge', 'aerial-ace', 'dragon-claw', 'calm-mind', 'dragon-dance', 'shock-wave', 'water-pulse', 'roost', 'natural-gift', 'tailwind', 'psycho-shift', 'heal-block', 'last-resort', 'dragon-pulse', 'energy-ball', 'giga-impact', 'shadow-claw', 'zen-headbutt', 'defog', 'draco-meteor', 'captivate', 'grass-knot', 'charge-beam', 'hone-claws', 'power-split', 'wonder-room', 'psyshock', 'telekinesis', 'round', 'stored-power', 'heal-pulse', 'retaliate', 'bulldoze', 'confide'], 'name': 'latios', 'stats': {'hp': 80, 'attack': 90, 'defense': 80, 'special-attack': 130, 'special-defense': 110, 'speed': 110}, 'types': ['dragon', 'psychic'], 'weight': 600, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': 0, 'capture_rate': 3, 'color': 'blue', 'shape': 'wings', 'habitat': 'waters-edge', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ラティオス', 'roomaji': 'Latios', 'ko': '라티오스', 'zh-Hant': '拉帝歐斯', 'fr': 'Latios', 'de': 'Latios', 'es': 'Latios', 'it': 'Latios', 'en': 'Latios', 'ja': 'ラティオス', 'zh-Hans': '拉帝欧斯'}, 'genera': {'ja-Hrkt': 'むげんポケモン', 'ko': '무한포켓몬', 'zh-Hant': '無限寶可夢', 'fr': 'Pokémon Éon', 'de': 'Äon', 'es': 'Pokémon Eón', 'it': 'Pokémon Eone', 'en': 'Eon Pokémon', 'ja': 'むげんポケモン', 'zh-Hans': '无限宝可梦'}}
	public class SpecieLatios : PokemonSpecie
	{
#nullable enable
		private static SpecieLatios? _instance = null;
#nullable restore
        public static SpecieLatios Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLatios();
                }
                return _instance;
            }
        }

		public SpecieLatios() : base(
			"Latios",
			80, // HPs
			90, 80, // Attack & Defense
			130, 110, // Special Attack & Defense
			110			
		) {}
	}


	//Latios Pokemon Class
	public class Latios : Pokemon
	{

		public Latios(string nickname, int level) : base(
			381,
			SpecieLatios.Instance, // Pokemon Specie
			nickname, level,
			Dragon.Instance, Psychic.Instance			
		) {}

		public Latios() : base(
			381,
			SpecieLatios.Instance, // Pokemon Specie
			Dragon.Instance, Psychic.Instance			
		) {}
	}
}