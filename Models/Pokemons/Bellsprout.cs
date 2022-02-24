using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Bellsprout Specie to store common natural stats of every {'abilities': ['chlorophyll', 'gluttony'], 'base_experience': 60, 'height': 7, 'id': 69, 'moves': ['swords-dance', 'cut', 'bind', 'slam', 'vine-whip', 'wrap', 'take-down', 'double-edge', 'acid', 'mega-drain', 'growth', 'razor-leaf', 'solar-beam', 'poison-powder', 'stun-spore', 'sleep-powder', 'toxic', 'rage', 'mimic', 'double-team', 'reflect', 'bide', 'leech-life', 'flash', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'sludge-bomb', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'encore', 'sweet-scent', 'synthesis', 'hidden-power', 'sunny-day', 'facade', 'nature-power', 'ingrain', 'knock-off', 'secret-power', 'weather-ball', 'tickle', 'bullet-seed', 'magical-leaf', 'natural-gift', 'wring-out', 'gastro-acid', 'worry-seed', 'sucker-punch', 'poison-jab', 'seed-bomb', 'energy-ball', 'power-whip', 'captivate', 'grass-knot', 'venoshock', 'acid-spray', 'round', 'clear-smog', 'belch', 'confide', 'infestation', 'strength-sap'], 'name': 'bellsprout', 'stats': {'hp': 50, 'attack': 75, 'defense': 35, 'special-attack': 70, 'special-defense': 30, 'speed': 40}, 'types': ['grass', 'poison'], 'weight': 40, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'green', 'shape': 'humanoid', 'habitat': 'forest', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'マダツボミ', 'roomaji': 'Madatsubomi', 'ko': '모다피', 'zh-Hant': '喇叭芽', 'fr': 'Chétiflor', 'de': 'Knofensa', 'es': 'Bellsprout', 'it': 'Bellsprout', 'en': 'Bellsprout', 'ja': 'マダツボミ', 'zh-Hans': '喇叭芽'}, 'genera': {'ja-Hrkt': 'フラワーポケモン', 'ko': '꽃포켓몬', 'zh-Hant': '花寶可夢', 'fr': 'Pokémon Fleur', 'de': 'Blume', 'es': 'Pokémon Flor', 'it': 'Pokémon Fiore', 'en': 'Flower Pokémon', 'ja': 'フラワーポケモン', 'zh-Hans': '花宝可梦'}}
	public class SpecieBellsprout : PokemonSpecie
	{
#nullable enable
		private static SpecieBellsprout? _instance = null;
#nullable restore
        public static SpecieBellsprout Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBellsprout();
                }
                return _instance;
            }
        }

		public SpecieBellsprout() : base(
			"Bellsprout",
			50, // HPs
			75, 35, // Attack & Defense
			70, 30, // Special Attack & Defense
			40			
		) {}
	}


	//Bellsprout Pokemon Class
	public class Bellsprout : Pokemon
	{

		public Bellsprout(string nickname, int level)
		: base(
				69,
				SpecieBellsprout.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Bellsprout(int level)
		: base(
				69,
				SpecieBellsprout.Instance, // Pokemon Specie
				"Bellsprout", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Bellsprout() : base(
			69,
			SpecieBellsprout.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
	}
}