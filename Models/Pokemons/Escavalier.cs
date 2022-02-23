using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Escavalier Specie to store common natural stats of every {'abilities': ['swarm', 'shell-armor', 'overcoat'], 'base_experience': 173, 'height': 10, 'id': 589, 'moves': ['swords-dance', 'cut', 'headbutt', 'fury-attack', 'double-edge', 'twineedle', 'leer', 'hyper-beam', 'peck', 'toxic', 'double-team', 'rest', 'slash', 'substitute', 'snore', 'reversal', 'protect', 'giga-drain', 'false-swipe', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'rock-smash', 'facade', 'knock-off', 'secret-power', 'signal-beam', 'aerial-ace', 'iron-defense', 'poison-jab', 'x-scissor', 'bug-buzz', 'focus-blast', 'energy-ball', 'giga-impact', 'iron-head', 'bug-bite', 'round', 'quick-guard', 'struggle-bug', 'drill-run', 'fell-stinger', 'confide', 'infestation', 'smart-strike', 'brutal-swing'], 'name': 'escavalier', 'stats': {'hp': 70, 'attack': 135, 'defense': 105, 'special-attack': 60, 'special-defense': 105, 'speed': 20}, 'types': ['bug', 'steel'], 'weight': 330, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 75, 'color': 'gray', 'shape': 'arms', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'シュバルゴ', 'ko': '슈바르고', 'zh-Hant': '騎士蝸牛', 'fr': 'Lançargot', 'de': 'Cavalanzas', 'es': 'Escavalier', 'it': 'Escavalier', 'en': 'Escavalier', 'ja': 'シュバルゴ', 'zh-Hans': '骑士蜗牛'}, 'genera': {'ja-Hrkt': 'きへいポケモン', 'ko': '기병포켓몬', 'zh-Hant': '騎兵寶可夢', 'fr': 'Pokémon Chevalier', 'de': 'Kavallerie', 'es': 'Pokémon Soldado', 'it': 'Pokémon Cavaliere', 'en': 'Cavalry Pokémon', 'ja': 'きへいポケモン', 'zh-Hans': '骑兵宝可梦'}}
	public class SpecieEscavalier : PokemonSpecie
	{
#nullable enable
		private static SpecieEscavalier? _instance = null;
#nullable restore
        public static SpecieEscavalier Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEscavalier();
                }
                return _instance;
            }
        }

		public SpecieEscavalier() : base(
			"Escavalier",
			70, // HPs
			135, 105, // Attack & Defense
			60, 105, // Special Attack & Defense
			20			
		) {}
	}


	//Escavalier Pokemon Class
	public class Escavalier : Pokemon
	{

		public Escavalier(string nickname, int level) : base(
			589,
			SpecieEscavalier.Instance, // Pokemon Specie
			nickname, level,
			Bug.Instance, Steel.Instance			
		) {}

		public Escavalier() : base(
			589,
			SpecieEscavalier.Instance, // Pokemon Specie
			Bug.Instance, Steel.Instance			
		) {}
	}
}