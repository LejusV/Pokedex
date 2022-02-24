using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Necrozma Specie to store common natural stats of every {'abilities': ['prism-armor'], 'base_experience': 270, 'height': 24, 'id': 800, 'moves': ['swords-dance', 'hyper-beam', 'solar-beam', 'thunder-wave', 'earthquake', 'toxic', 'confusion', 'psychic', 'double-team', 'light-screen', 'reflect', 'rest', 'rock-slide', 'slash', 'substitute', 'thief', 'protect', 'swagger', 'sleep-talk', 'return', 'frustration', 'metal-claw', 'morning-sun', 'moonlight', 'hidden-power', 'facade', 'brick-break', 'rock-tomb', 'aerial-ace', 'iron-defense', 'calm-mind', 'rock-blast', 'gravity', 'gyro-ball', 'embargo', 'fling', 'wring-out', 'rock-polish', 'dark-pulse', 'night-slash', 'x-scissor', 'power-gem', 'giga-impact', 'shadow-claw', 'psycho-cut', 'mirror-shot', 'flash-cannon', 'trick-room', 'stone-edge', 'stealth-rock', 'charge-beam', 'psyshock', 'autotomize', 'round', 'stored-power', 'bulldoze', 'confide', 'smart-strike', 'brutal-swing', 'prismatic-laser', 'photon-geyser'], 'name': 'necrozma', 'stats': {'hp': 97, 'attack': 107, 'defense': 101, 'special-attack': 127, 'special-defense': 89, 'speed': 79}, 'types': ['psychic'], 'weight': 2300, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 255, 'color': 'black', 'shape': 'arms', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ネクロズマ', 'ko': '네크로즈마', 'zh-Hant': '奈克洛茲瑪', 'fr': 'Necrozma', 'de': 'Necrozma', 'es': 'Necrozma', 'it': 'Necrozma', 'en': 'Necrozma', 'ja': 'ネクロズマ', 'zh-Hans': '奈克洛兹玛'}, 'genera': {'ja-Hrkt': 'プリズムポケモン', 'ko': '프리즘포켓몬', 'zh-Hant': '稜鏡寶可夢', 'fr': 'Pokémon Prisme', 'de': 'Prisma', 'es': 'Pokémon Prisma', 'it': 'Pokémon Prisma', 'en': 'Prism Pokémon', 'ja': 'プリズムポケモン', 'zh-Hans': '棱镜宝可梦'}}
	public class SpecieNecrozma : PokemonSpecie
	{
#nullable enable
		private static SpecieNecrozma? _instance = null;
#nullable restore
        public static SpecieNecrozma Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNecrozma();
                }
                return _instance;
            }
        }

		public SpecieNecrozma() : base(
			"Necrozma",
			97, // HPs
			107, 101, // Attack & Defense
			127, 89, // Special Attack & Defense
			79			
		) {}
	}


	//Necrozma Pokemon Class
	public class Necrozma : Pokemon
	{

		public Necrozma(string nickname, int level)
		: base(
				800,
				SpecieNecrozma.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Necrozma(int level)
		: base(
				800,
				SpecieNecrozma.Instance, // Pokemon Specie
				"Necrozma", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Necrozma() : base(
			800,
			SpecieNecrozma.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}