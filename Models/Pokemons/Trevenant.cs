using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Trevenant Specie to store common natural stats of every {'abilities': ['natural-cure', 'frisk', 'harvest'], 'base_experience': 166, 'height': 15, 'id': 709, 'moves': ['cut', 'tackle', 'hyper-beam', 'strength', 'leech-seed', 'growth', 'solar-beam', 'earthquake', 'dig', 'toxic', 'psychic', 'double-team', 'confuse-ray', 'reflect', 'dream-eater', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'spite', 'protect', 'feint-attack', 'destiny-bond', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'hidden-power', 'sunny-day', 'shadow-ball', 'rock-smash', 'will-o-wisp', 'facade', 'nature-power', 'trick', 'role-play', 'ingrain', 'magic-coat', 'skill-swap', 'secret-power', 'astonish', 'block', 'calm-mind', 'worry-seed', 'poison-jab', 'dark-pulse', 'seed-bomb', 'x-scissor', 'drain-punch', 'focus-blast', 'energy-ball', 'giga-impact', 'shadow-claw', 'trick-room', 'grass-knot', 'wood-hammer', 'hone-claws', 'foul-play', 'round', 'bulldoze', 'horn-leech', 'phantom-force', 'forests-curse', 'confide', 'power-up-punch', 'brutal-swing'], 'name': 'trevenant', 'stats': {'hp': 85, 'attack': 110, 'defense': 76, 'special-attack': 65, 'special-defense': 82, 'speed': 56}, 'types': ['ghost', 'grass'], 'weight': 710, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'brown', 'shape': 'tentacles', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['plant', 'indeterminate'], 'names': {'ja-Hrkt': 'オーロット', 'ko': '대로트', 'zh-Hant': '朽木妖', 'fr': 'Desséliande', 'de': 'Trombork', 'es': 'Trevenant', 'it': 'Trevenant', 'en': 'Trevenant', 'ja': 'オーロット', 'zh-Hans': '朽木妖'}, 'genera': {'ja-Hrkt': 'ろうぼくポケモン', 'ko': '고목포켓몬', 'zh-Hant': '老樹寶可夢', 'fr': 'Pokémon Vieillarbre', 'de': 'Urgehölz', 'es': 'Pokémon Árbol Viejo', 'it': 'Pokémon Alberantico', 'en': 'Elder Tree Pokémon', 'ja': 'ろうぼくポケモン', 'zh-Hans': '老树宝可梦'}}
	public class SpecieTrevenant : PokemonSpecie
	{
#nullable enable
		private static SpecieTrevenant? _instance = null;
#nullable restore
        public static SpecieTrevenant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTrevenant();
                }
                return _instance;
            }
        }

		public SpecieTrevenant() : base(
			"Trevenant",
			85, // HPs
			110, 76, // Attack & Defense
			65, 82, // Special Attack & Defense
			56			
		) {}
	}


	//Trevenant Pokemon Class
	public class Trevenant : Pokemon
	{

		public Trevenant(string nickname, int level)
		: base(
				709,
				SpecieTrevenant.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Trevenant() : base(
			709,
			SpecieTrevenant.Instance, // Pokemon Specie
			Ghost.Instance, Grass.Instance			
		) {}
	}
}