using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Grimer Specie to store common natural stats of every {'abilities': ['stench', 'sticky-hold', 'poison-touch'], 'base_experience': 65, 'height': 9, 'id': 88, 'moves': ['pound', 'fire-punch', 'ice-punch', 'thunder-punch', 'body-slam', 'disable', 'flamethrower', 'strength', 'mega-drain', 'thunderbolt', 'thunder', 'dig', 'toxic', 'rage', 'mimic', 'screech', 'double-team', 'harden', 'minimize', 'haze', 'bide', 'self-destruct', 'lick', 'sludge', 'fire-blast', 'poison-gas', 'acid-armor', 'explosion', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'protect', 'scary-face', 'sludge-bomb', 'mud-slap', 'zap-cannon', 'giga-drain', 'endure', 'swagger', 'mean-look', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'dynamic-punch', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'stockpile', 'spit-up', 'swallow', 'torment', 'memento', 'facade', 'taunt', 'imprison', 'secret-power', 'rock-tomb', 'shadow-punch', 'shock-wave', 'natural-gift', 'payback', 'fling', 'poison-jab', 'shadow-sneak', 'mud-bomb', 'gunk-shot', 'captivate', 'venoshock', 'sludge-wave', 'acid-spray', 'round', 'incinerate', 'belch', 'confide', 'infestation', 'power-up-punch'], 'name': 'grimer', 'stats': {'hp': 80, 'attack': 80, 'defense': 50, 'special-attack': 40, 'special-defense': 50, 'speed': 25}, 'types': ['poison'], 'weight': 300, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'purple', 'shape': 'arms', 'habitat': 'urban', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'ベトベター', 'roomaji': 'Betbeter', 'ko': '질퍽이', 'zh-Hant': '臭泥', 'fr': 'Tadmorv', 'de': 'Sleima', 'es': 'Grimer', 'it': 'Grimer', 'en': 'Grimer', 'ja': 'ベトベター', 'zh-Hans': '臭泥'}, 'genera': {'ja-Hrkt': 'ヘドロポケモン', 'ko': '진흙포켓몬', 'zh-Hant': '污泥寶可夢', 'fr': 'Pokémon Dégueu', 'de': 'Schlamm', 'es': 'Pokémon Lodo', 'it': 'Pokémon Melma', 'en': 'Sludge Pokémon', 'ja': 'ヘドロポケモン', 'zh-Hans': '污泥宝可梦'}}
	public class SpecieGrimer : PokemonSpecie
	{
#nullable enable
		private static SpecieGrimer? _instance = null;
#nullable restore
        public static SpecieGrimer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGrimer();
                }
                return _instance;
            }
        }

		public SpecieGrimer() : base(
			"Grimer",
			80, // HPs
			80, 50, // Attack & Defense
			40, 50, // Special Attack & Defense
			25			
		) {}
	}


	//Grimer Pokemon Class
	public class Grimer : Pokemon
	{

		public Grimer(string nickname, int level)
		: base(
				88,
				SpecieGrimer.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Grimer() : base(
			88,
			SpecieGrimer.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
	}
}