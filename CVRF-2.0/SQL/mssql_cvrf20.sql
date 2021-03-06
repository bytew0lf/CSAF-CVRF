IF NOT EXISTS (
    select * from sysobjects where name='cvrf20' and xtype='U'
) CREATE TABLE cvrf20 (
    [document_csaf_version] NUMERIC(2, 1),
    [document_title] NVARCHAR(18),
    [document_publisher_type] NVARCHAR(10),
    [document_publisher_contact_details] NVARCHAR(19),
    [document_publisher_issuing_authority] NVARCHAR(21),
    [document_publisher_vendor_id] NVARCHAR(26),
    [document_type] NVARCHAR(25),
    [document_tracking_current_release_date] NVARCHAR(12),
    [document_tracking_id] NVARCHAR(26),
    [document_tracking_initial_release_date] NVARCHAR(4),
    [document_tracking_revision_history_number] NUMERIC(2, 1),
    [document_tracking_revision_history_date] NVARCHAR(21),
    [document_tracking_revision_history_description] NVARCHAR(24),
    [document_tracking_status] NVARCHAR(7),
    [document_tracking_version] NUMERIC(2, 1),
    [document_tracking_aliases] NVARCHAR(20),
    [document_tracking_generator_engine] NVARCHAR(17),
    [document_tracking_generator_date] NVARCHAR(20),
    [document_acknowledgments_names] INT,
    [document_acknowledgments_organizations] NUMERIC(5, 2),
    [document_acknowledgments_description] NVARCHAR(24),
    [document_acknowledgments_urls] NVARCHAR(5),
    [document_aggregate_severity_text] NVARCHAR(12),
    [document_aggregate_severity_namespace] NVARCHAR(8),
    [document_distribution_text] NVARCHAR(22),
    [document_distribution_tlp_label] NVARCHAR(5),
    [document_distribution_tlp_url] NVARCHAR(14),
    [document_lang] NVARCHAR(5),
    [document_source_lang] NVARCHAR(5),
    [document_notes_type] NVARCHAR(7),
    [document_notes_text] NVARCHAR(22),
    [document_notes_audience] NVARCHAR(5),
    [document_notes_title] NVARCHAR(8),
    [document_references_url] NVARCHAR(17),
    [document_references_description] NVARCHAR(7),
    [document_references_type] NVARCHAR(8),
    [product_tree_branches_name] NVARCHAR(23),
    [product_tree_branches_type] NVARCHAR(8),
    [product_tree_branches_branches_name] NVARCHAR(25),
    [product_tree_branches_branches_type] NVARCHAR(6),
    [product_tree_branches_branches_branches_name] NVARCHAR(16),
    [product_tree_branches_branches_branches_type] NVARCHAR(12),
    [product_tree_branches_branches_branches_branches_name] NVARCHAR(21),
    [product_tree_branches_branches_branches_branches_type] NVARCHAR(9),
    [product_tree_branches_branches_branches_branches_branches_name] NVARCHAR(19),
    [product_tree_branches_branches_branches_branches_branches_type] NVARCHAR(12),
    [tree_branches_branches_branches_branches_branches_branches_name] NVARCHAR(7),
    [tree_branches_branches_branches_branches_branches_branches_type] NVARCHAR(12),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(19),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(6),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(5),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(6),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(22),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(8),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(29),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(8),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(11),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(6),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(20),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(8),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(6),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(13),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(23),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(12),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(23),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(11),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(14),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(14),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(12),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(11),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(18),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(12),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(7),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(11),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(23),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(11),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(15),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(6),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(12),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(12),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(21),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(14),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(10),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(6),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(7),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(6),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(6),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(6),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(18),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(12),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(6),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(9),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(8),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(9),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(8),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(14),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(8),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(6),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(12),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(14),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(7),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(8),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(29),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(9),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(10),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(12),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(14),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(14),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(11),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(15),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(23),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(12),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(20),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(8),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(24),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(12),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(20),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(6),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(9),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(12),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(10),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(13),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(13),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(12),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(29),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(13),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(18),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(14),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(14),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(12),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(21),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(11),
    [branches_branches_branches_branches_branches_branches_name] NVARCHAR(15),
    [branches_branches_branches_branches_branches_branches_type] NVARCHAR(9),
    [branches_branches_branches_branches_branches_branches_branches] NVARCHAR(167),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(167),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(167),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(167),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(13),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(11),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(13),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(25),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(18),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(11),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(29),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(7),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(11),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(9),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(26),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(14),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(20),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(28),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(5),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(26),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(21),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(9),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(14),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(12),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(7),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(22),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(13),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(7),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(11),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(9),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(5),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(16),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(27),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(8),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(18),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(11),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(7),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(9),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(27),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(9),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(19),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(13),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(9),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(5),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(16),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(12),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(11),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(27),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(9),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(28),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(10),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(7),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(19),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(4),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(8),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(29),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(11),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(7),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(25),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(12),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(11),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(14),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(14),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(14),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(20),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(20),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(10),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(5),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(4),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(9),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(26),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(24),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(14),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(21),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(15),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(10),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(25),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(14),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(13),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(23),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(12),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(15),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(7),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(12),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(12),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(15),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(16),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(5),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(13),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(20),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(15),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(14),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(27),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(6),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(29),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(13),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(8),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(27),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(5),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(13),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(18),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(20),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(9),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(21),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(25),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(12),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(4),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(28),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(8),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(14),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(18),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(8),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(27),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(26),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(8),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(10),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(19),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(12),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(26),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(4),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(11),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(22),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(12),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(8),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(10),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(4),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(8),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(26),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(14),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(7),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(14),
    [branches_branches_branches_branches_branches_product_name] NVARCHAR(8),
    [branches_branches_branches_branches_branches_product_cpe] NVARCHAR(13),
    [branches_branches_branches_branches_branches_product_product_id] NVARCHAR(4),
    [tree_branches_branches_branches_branches_branches_product_name] NVARCHAR(29),
    [tree_branches_branches_branches_branches_branches_product_cpe] NVARCHAR(6),
    [tree_branches_branches_branches_branches_product_product_id] NVARCHAR(25),
    [product_tree_branches_branches_branches_branches_product_name] NVARCHAR(4),
    [product_tree_branches_branches_branches_branches_product_cpe] NVARCHAR(6),
    [product_tree_branches_branches_branches_product_product_id] NVARCHAR(17),
    [product_tree_branches_branches_branches_product_name] NVARCHAR(25),
    [product_tree_branches_branches_branches_product_cpe] NVARCHAR(5),
    [product_tree_branches_branches_product_product_id] NVARCHAR(24),
    [product_tree_branches_branches_product_name] NVARCHAR(21),
    [product_tree_branches_branches_product_cpe] NVARCHAR(14),
    [product_tree_branches_product_product_id] NVARCHAR(17),
    [product_tree_branches_product_name] NVARCHAR(17),
    [product_tree_branches_product_cpe] NVARCHAR(9),
    [product_tree_full_product_names_product_id] NVARCHAR(12),
    [product_tree_full_product_names_name] NVARCHAR(28),
    [product_tree_full_product_names_cpe] NVARCHAR(9),
    [product_tree_product_groups_group_id] NVARCHAR(9),
    [product_tree_product_groups_product_ids] NVARCHAR(12),
    [product_tree_product_groups_description] NVARCHAR(19),
    [product_tree_relationships_product_reference] NVARCHAR(27),
    [product_tree_relationships_relates_to_product_reference] NVARCHAR(20),
    [product_tree_relationships_relationship_type] NVARCHAR(21),
    [product_tree_relationships_full_product_names_product_id] NVARCHAR(15),
    [product_tree_relationships_full_product_names_name] NVARCHAR(23),
    [product_tree_relationships_full_product_names_cpe] NVARCHAR(9),
    [vulnerabilities_acknowledgments_names] INT,
    [vulnerabilities_acknowledgments_organizations] INT,
    [vulnerabilities_acknowledgments_description] NVARCHAR(21),
    [vulnerabilities_acknowledgments_urls] NVARCHAR(25),
    [vulnerabilities_cve] NVARCHAR(13),
    [vulnerabilities_cwe_id] NVARCHAR(5),
    [vulnerabilities_cwe_description] NVARCHAR(5),
    [vulnerabilities_discovery_date] NVARCHAR(18),
    [vulnerabilities_id_system_name] NVARCHAR(5),
    [vulnerabilities_id_text] NVARCHAR(27),
    [vulnerabilities_involvements_party] NVARCHAR(5),
    [vulnerabilities_involvements_status] NVARCHAR(13),
    [vulnerabilities_involvements_description] NVARCHAR(26),
    [vulnerabilities_notes_type] NVARCHAR(5),
    [vulnerabilities_notes_text] NVARCHAR(24),
    [vulnerabilities_notes_audience] NVARCHAR(16),
    [vulnerabilities_notes_title] NVARCHAR(20),
    [vulnerabilities_product_status_fixed] NVARCHAR(15),
    [vulnerabilities_product_status_first_fixed] NVARCHAR(28),
    [vulnerabilities_product_status_recommended] NVARCHAR(7),
    [vulnerabilities_product_status_known_affected] NVARCHAR(16),
    [vulnerabilities_product_status_first_affected] NVARCHAR(5),
    [vulnerabilities_product_status_last_affected] NVARCHAR(15),
    [vulnerabilities_product_status_known_not_affected] NVARCHAR(17),
    [vulnerabilities_product_status_under_investigation] NVARCHAR(18),
    [vulnerabilities_references_url] NVARCHAR(9),
    [vulnerabilities_references_description] NVARCHAR(12),
    [vulnerabilities_references_type] NVARCHAR(8),
    [vulnerabilities_release_date] NVARCHAR(8),
    [vulnerabilities_remediations_description] NVARCHAR(9),
    [vulnerabilities_remediations_type] NVARCHAR(14),
    [vulnerabilities_remediations_date] NVARCHAR(8),
    [vulnerabilities_remediations_entitlements] NVARCHAR(21),
    [vulnerabilities_remediations_group_ids] NVARCHAR(20),
    [vulnerabilities_remediations_product_ids] NVARCHAR(26),
    [vulnerabilities_remediations_restart_required_type] NVARCHAR(6),
    [vulnerabilities_remediations_restart_required_description] NVARCHAR(19),
    [vulnerabilities_remediations_url] NVARCHAR(12),
    [vulnerabilities_threats_description] NVARCHAR(17),
    [vulnerabilities_threats_type] NVARCHAR(6),
    [vulnerabilities_threats_date] NVARCHAR(25),
    [vulnerabilities_threats_product_ids] NVARCHAR(8),
    [vulnerabilities_threats_group_ids] NVARCHAR(23),
    [vulnerabilities_title] NVARCHAR(9)
);
INSERT INTO cvrf20 VALUES
    (2.0,N'ABCDEFGHIJKLMNOPQR',N'discoverer',N'ABCDEFGHIJKLMNOPQRS',N'ABCDEFGHIJKLMNOPQRSTU',N'ABCDEFGHIJKLMNOPQRSTUVWXYZ',N'ABCDEFGHIJKLMNOPQRSTUVWXY',N'ABCDEFGHIJKL',N'ABCDEFGHIJKLMNOPQRSTUVWXYZ',N'ABCD',0.5,N'ABCDEFGHIJKLMNOPQRSTU',N'ABCDEFGHIJKLMNOPQRSTUVWX',N'interim',3.9,N'ABCDEFGHIJKLMNOPQRST',N'ABCDEFGHIJKLMNOPQ',N'ABCDEFGHIJKLMNOPQRST',NULL,466.25,N'ABCDEFGHIJKLMNOPQRSTUVWX',N'ABCDE',N'ABCDEFGHIJKL',N'ABCDEFGH',N'ABCDEFGHIJKLMNOPQRSTUV',N'WHITE',N'ABCDEFGHIJKLMN',N'BAt-$',N'lP-0*',N'summary',N'ABCDEFGHIJKLMNOPQRSTUV',N'ABCDE',N'ABCDEFGH',N'ABCDEFGHIJKLMNOPQ',N'ABCDEFG',N'external',N'ABCDEFGHIJKLMNOPQRSTUVW',N'language',N'ABCDEFGHIJKLMNOPQRSTUVWXY',N'vendor',N'ABCDEFGHIJKLMNOP',N'architecture',N'ABCDEFGHIJKLMNOPQRSTU',N'host_name',N'ABCDEFGHIJKLMNOPQRS',N'service_pack',N'ABCDEFG',N'product_name',N'ABCDEFGHIJKLMNOPQRS',N'legacy',N'ABCDE',N'legacy',N'ABCDEFGHIJKLMNOPQRSTUV',N'language',N'ABCDEFGHIJKLMNOPQRSTUVWXYZABC',N'language',N'ABCDEFGHIJK',N'legacy',N'ABCDEFGHIJKLMNOPQRST',N'language',N'ABCDEF',N'specification',N'ABCDEFGHIJKLMNOPQRSTUVW',N'product_name',N'ABCDEFGHIJKLMNOPQRSTUVW',N'patch_level',N'ABCDEFGHIJKLMN',N'product_family',N'ABCDEFGHIJKL',N'patch_level',N'ABCDEFGHIJKLMNOPQR',N'product_name',N'ABCDEFG',N'patch_level',N'ABCDEFGHIJKLMNOPQRSTUVW',N'patch_level',N'ABCDEFGHIJKLMNO',N'vendor',N'ABCDEFGHIJKL',N'product_name',N'ABCDEFGHIJKLMNOPQRSTU',N'product_family',N'ABCDEFGHIJ',N'legacy',N'ABCDEFG',N'vendor',N'ABCDEF',N'vendor',N'ABCDEFGHIJKLMNOPQR',N'architecture',N'ABCDEF',N'host_name',N'ABCDEFGH',N'host_name',N'ABCDEFGH',N'product_family',N'ABCDEFGH',N'vendor',N'ABCDEFGHIJKL',N'product_family',N'ABCDEFG',N'language',N'ABCDEFGHIJKLMNOPQRSTUVWXYZABC',N'host_name',N'ABCDEFGHIJ',N'service_pack',N'ABCDEFGHIJKLMN',N'product_family',N'ABCDEFGHIJK',N'product_version',N'ABCDEFGHIJKLMNOPQRSTUVW',N'service_pack',N'ABCDEFGHIJKLMNOPQRST',N'language',N'ABCDEFGHIJKLMNOPQRSTUVWX',N'service_pack',N'ABCDEFGHIJKLMNOPQRST',N'vendor',N'ABCDEFGHI',N'product_name',N'ABCDEFGHIJ',N'specification',N'ABCDEFGHIJKLM',N'product_name',N'ABCDEFGHIJKLMNOPQRSTUVWXYZABC',N'specification',N'ABCDEFGHIJKLMNOPQR',N'product_family',N'ABCDEFGHIJKLMN',N'service_pack',N'ABCDEFGHIJKLMNOPQRSTU',N'patch_level',N'ABCDEFGHIJKLMNO',N'host_name',N'Error: Iteration depth exceeded. Possibly the result of a rule in the schema that forces the creation of an infinitely deep tree of objects (i.e. ''A'' contains 1-n ''A'')',N'Error: Iteration depth exceeded. Possibly the result of a rule in the schema that forces the creation of an infinitely deep tree of objects (i.e. ''A'' contains 1-n ''A'')',N'Error: Iteration depth exceeded. Possibly the result of a rule in the schema that forces the creation of an infinitely deep tree of objects (i.e. ''A'' contains 1-n ''A'')',N'Error: Iteration depth exceeded. Possibly the result of a rule in the schema that forces the creation of an infinitely deep tree of objects (i.e. ''A'' contains 1-n ''A'')',N'ABCDEFGHIJKLM',N'ABCDEFGHIJK',N'cpe:/78::**%:',N'ABCDEFGHIJKLMNOPQRSTUVWXY',N'ABCDEFGHIJKLMNOPQR',N'cpe:/N:^o:~',N'ABCDEFGHIJKLMNOPQRSTUVWXYZABC',N'ABCDEFG',N'cpe:001.4Lo',N'ABCDEFGHI',N'ABCDEFGHIJKLMNOPQRSTUVWXYZ',N'cpe:/:P::HO:70',N'ABCDEFGHIJKLMNOPQRST',N'ABCDEFGHIJKLMNOPQRSTUVWXYZAB',N'cpe:/',N'ABCDEFGHIJKLMNOPQRSTUVWXYZ',N'ABCDEFGHIJKLMNOPQRSTU',N'cpe:8.0'':',N'ABCDEFGHIJKLMN',N'ABCDEFGHIJKL',N'cpe:/a:',N'ABCDEFGHIJKLMNOPQRSTUV',N'ABCDEFGHIJKLM',N'cpe:/_[',N'ABCDEFGHIJK',N'ABCDEFGHI',N'cpe:/',N'ABCDEFGHIJKLMNOP',N'ABCDEFGHIJKLMNOPQRSTUVWXYZA',N'cpe:9.6|',N'ABCDEFGHIJKLMNOPQR',N'ABCDEFGHIJK',N'cpe:5.1',N'ABCDEFGHI',N'ABCDEFGHIJKLMNOPQRSTUVWXYZA',N'cpe:/@Aj5',N'ABCDEFGHIJKLMNOPQRS',N'ABCDEFGHIJKLM',N'cpe:9.6*n',N'ABCDE',N'ABCDEFGHIJKLMNOP',N'cpe:35.0ly:;',N'ABCDEFGHIJK',N'ABCDEFGHIJKLMNOPQRSTUVWXYZA',N'cpe:644.3',N'ABCDEFGHIJKLMNOPQRSTUVWXYZAB',N'ABCDEFGHIJ',N'cpe:/#:',N'ABCDEFGHIJKLMNOPQRS',N'ABCD',N'cpe:32.7',N'ABCDEFGHIJKLMNOPQRSTUVWXYZABC',N'ABCDEFGHIJK',N'cpe:2.0',N'ABCDEFGHIJKLMNOPQRSTUVWXY',N'ABCDEFGHIJKL',N'cpe:/0:)::j',N'ABCDEFGHIJKLMN',N'ABCDEFGHIJKLMN',N'cpe:580308.9::',N'ABCDEFGHIJKLMNOPQRST',N'ABCDEFGHIJKLMNOPQRST',N'cpe:9.9-u:',N'ABCDE',N'ABCD',N'cpe:9.0::',N'ABCDEFGHIJKLMNOPQRSTUVWXYZ',N'ABCDEFGHIJKLMNOPQRSTUVWX',N'cpe:1.6{:_::::',N'ABCDEFGHIJKLMNOPQRSTU',N'ABCDEFGHIJKLMNO',N'cpe:0.0G-/',N'ABCDEFGHIJKLMNOPQRSTUVWXY',N'ABCDEFGHIJKLMN',N'cpe:5583.0:::',N'ABCDEFGHIJKLMNOPQRSTUVW',N'ABCDEFGHIJKL',N'cpe:20.1:5:)9pu',N'ABCDEFG',N'ABCDEFGHIJKL',N'cpe:/:XsNC:~',N'ABCDEFGHIJKLMNO',N'ABCDEFGHIJKLMNOP',N'cpe:/',N'ABCDEFGHIJKLM',N'ABCDEFGHIJKLMNOPQRST',N'cpe:86.7I:::*$s',N'ABCDEFGHIJKLMN',N'ABCDEFGHIJKLMNOPQRSTUVWXYZA',N'cpe:/i',N'ABCDEFGHIJKLMNOPQRSTUVWXYZABC',N'ABCDEFGHIJKLM',N'cpe:/o:e',N'ABCDEFGHIJKLMNOPQRSTUVWXYZA',N'ABCDE',N'cpe:707329.5q',N'ABCDEFGHIJKLMNOPQR',N'ABCDEFGHIJKLMNOPQRST',N'cpe:2.71k',N'ABCDEFGHIJKLMNOPQRSTU',N'ABCDEFGHIJKLMNOPQRSTUVWXY',N'cpe:/e:''%Y>:',N'ABCD',N'ABCDEFGHIJKLMNOPQRSTUVWXYZAB',N'cpe:3.2U',N'ABCDEFGHIJKLMN',N'ABCDEFGHIJKLMNOPQR',N'cpe:/DTD',N'ABCDEFGHIJKLMNOPQRSTUVWXYZA',N'ABCDEFGHIJKLMNOPQRSTUVWXYZ',N'cpe:/::L',N'ABCDEFGHIJ',N'ABCDEFGHIJKLMNOPQRS',N'cpe:/io''+dC:',N'ABCDEFGHIJKLMNOPQRSTUVWXYZ',N'ABCD',N'cpe:/:[4v::',N'ABCDEFGHIJKLMNOPQRSTUV',N'ABCDEFGHIJKL',N'cpe:8.8:',N'ABCDEFGHIJ',N'ABCD',N'cpe:4.4*',N'ABCDEFGHIJKLMNOPQRSTUVWXYZ',N'ABCDEFGHIJKLMN',N'cpe:/d]',N'ABCDEFGHIJKLMN',N'ABCDEFGH',N'cpe:/gR:-68::',N'ABCD',N'ABCDEFGHIJKLMNOPQRSTUVWXYZABC',N'cpe:/:',N'ABCDEFGHIJKLMNOPQRSTUVWXY',N'ABCD',N'cpe:/.',N'ABCDEFGHIJKLMNOPQ',N'ABCDEFGHIJKLMNOPQRSTUVWXY',N'cpe:/',N'ABCDEFGHIJKLMNOPQRSTUVWX',N'ABCDEFGHIJKLMNOPQRSTU',N'cpe:701.2''B:Pe',N'ABCDEFGHIJKLMNOPQ',N'ABCDEFGHIJKLMNOPQ',N'cpe:6.6?/',N'ABCDEFGHIJKL',N'ABCDEFGHIJKLMNOPQRSTUVWXYZAB',N'cpe:/1Ed:',N'ABCDEFGHI',N'ABCDEFGHIJK',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),
    (2.0,N'ABCDEFGHIJKLMNOPQR',N'discoverer',N'ABCDEFGHIJKLMNOPQRS',N'ABCDEFGHIJKLMNOPQRSTU',N'ABCDEFGHIJKLMNOPQRSTUVWXYZ',N'ABCDEFGHIJKLMNOPQRSTUVWXY',N'ABCDEFGHIJKL',N'ABCDEFGHIJKLMNOPQRSTUVWXYZ',N'ABCD',0.5,N'ABCDEFGHIJKLMNOPQRSTU',N'ABCDEFGHIJKLMNOPQRSTUVWX',N'interim',3.9,N'ABCDEFGHIJKLMNOPQRST',N'ABCDEFGHIJKLMNOPQ',N'ABCDEFGHIJKLMNOPQRST',NULL,466.25,N'ABCDEFGHIJKLMNOPQRSTUVWX',N'ABCDE',N'ABCDEFGHIJKL',N'ABCDEFGH',N'ABCDEFGHIJKLMNOPQRSTUV',N'WHITE',N'ABCDEFGHIJKLMN',N'BAt-$',N'lP-0*',N'summary',N'ABCDEFGHIJKLMNOPQRSTUV',N'ABCDE',N'ABCDEFGH',N'ABCDEFGHIJKLMNOPQ',N'ABCDEFG',N'external',N'ABCDEFGHIJKLMNOPQRSTUVW',N'language',N'ABCDEFGHIJKLMNOPQRSTUVWXY',N'vendor',N'ABCDEFGHIJKLMNOP',N'architecture',N'ABCDEFGHIJKLMNOPQRSTU',N'host_name',N'ABCDEFGHIJKLMNOPQRS',N'service_pack',N'ABCDEFG',N'product_name',N'ABCDEFGHIJKLMNOPQRS',N'legacy',N'ABCDE',N'legacy',N'ABCDEFGHIJKLMNOPQRSTUV',N'language',N'ABCDEFGHIJKLMNOPQRSTUVWXYZABC',N'language',N'ABCDEFGHIJK',N'legacy',N'ABCDEFGHIJKLMNOPQRST',N'language',N'ABCDEF',N'specification',N'ABCDEFGHIJKLMNOPQRSTUVW',N'product_name',N'ABCDEFGHIJKLMNOPQRSTUVW',N'patch_level',N'ABCDEFGHIJKLMN',N'product_family',N'ABCDEFGHIJKL',N'patch_level',N'ABCDEFGHIJKLMNOPQR',N'product_name',N'ABCDEFG',N'patch_level',N'ABCDEFGHIJKLMNOPQRSTUVW',N'patch_level',N'ABCDEFGHIJKLMNO',N'vendor',N'ABCDEFGHIJKL',N'product_name',N'ABCDEFGHIJKLMNOPQRSTU',N'product_family',N'ABCDEFGHIJ',N'legacy',N'ABCDEFG',N'vendor',N'ABCDEF',N'vendor',N'ABCDEFGHIJKLMNOPQR',N'architecture',N'ABCDEF',N'host_name',N'ABCDEFGH',N'host_name',N'ABCDEFGH',N'product_family',N'ABCDEFGH',N'vendor',N'ABCDEFGHIJKL',N'product_family',N'ABCDEFG',N'language',N'ABCDEFGHIJKLMNOPQRSTUVWXYZABC',N'host_name',N'ABCDEFGHIJ',N'service_pack',N'ABCDEFGHIJKLMN',N'product_family',N'ABCDEFGHIJK',N'product_version',N'ABCDEFGHIJKLMNOPQRSTUVW',N'service_pack',N'ABCDEFGHIJKLMNOPQRST',N'language',N'ABCDEFGHIJKLMNOPQRSTUVWX',N'service_pack',N'ABCDEFGHIJKLMNOPQRST',N'vendor',N'ABCDEFGHI',N'product_name',N'ABCDEFGHIJ',N'specification',N'ABCDEFGHIJKLM',N'product_name',N'ABCDEFGHIJKLMNOPQRSTUVWXYZABC',N'specification',N'ABCDEFGHIJKLMNOPQR',N'product_family',N'ABCDEFGHIJKLMN',N'service_pack',N'ABCDEFGHIJKLMNOPQRSTU',N'patch_level',N'ABCDEFGHIJKLMNO',N'host_name',N'Error: Iteration depth exceeded. Possibly the result of a rule in the schema that forces the creation of an infinitely deep tree of objects (i.e. ''A'' contains 1-n ''A'')',N'Error: Iteration depth exceeded. Possibly the result of a rule in the schema that forces the creation of an infinitely deep tree of objects (i.e. ''A'' contains 1-n ''A'')',N'Error: Iteration depth exceeded. Possibly the result of a rule in the schema that forces the creation of an infinitely deep tree of objects (i.e. ''A'' contains 1-n ''A'')',N'Error: Iteration depth exceeded. Possibly the result of a rule in the schema that forces the creation of an infinitely deep tree of objects (i.e. ''A'' contains 1-n ''A'')',N'ABCDEFGHIJKLM',N'ABCDEFGHIJK',N'cpe:/78::**%:',N'ABCDEFGHIJKLMNOPQRSTUVWXY',N'ABCDEFGHIJKLMNOPQR',N'cpe:/N:^o:~',N'ABCDEFGHIJKLMNOPQRSTUVWXYZABC',N'ABCDEFG',N'cpe:001.4Lo',N'ABCDEFGHI',N'ABCDEFGHIJKLMNOPQRSTUVWXYZ',N'cpe:/:P::HO:70',N'ABCDEFGHIJKLMNOPQRST',N'ABCDEFGHIJKLMNOPQRSTUVWXYZAB',N'cpe:/',N'ABCDEFGHIJKLMNOPQRSTUVWXYZ',N'ABCDEFGHIJKLMNOPQRSTU',N'cpe:8.0'':',N'ABCDEFGHIJKLMN',N'ABCDEFGHIJKL',N'cpe:/a:',N'ABCDEFGHIJKLMNOPQRSTUV',N'ABCDEFGHIJKLM',N'cpe:/_[',N'ABCDEFGHIJK',N'ABCDEFGHI',N'cpe:/',N'ABCDEFGHIJKLMNOP',N'ABCDEFGHIJKLMNOPQRSTUVWXYZA',N'cpe:9.6|',N'ABCDEFGHIJKLMNOPQR',N'ABCDEFGHIJK',N'cpe:5.1',N'ABCDEFGHI',N'ABCDEFGHIJKLMNOPQRSTUVWXYZA',N'cpe:/@Aj5',N'ABCDEFGHIJKLMNOPQRS',N'ABCDEFGHIJKLM',N'cpe:9.6*n',N'ABCDE',N'ABCDEFGHIJKLMNOP',N'cpe:35.0ly:;',N'ABCDEFGHIJK',N'ABCDEFGHIJKLMNOPQRSTUVWXYZA',N'cpe:644.3',N'ABCDEFGHIJKLMNOPQRSTUVWXYZAB',N'ABCDEFGHIJ',N'cpe:/#:',N'ABCDEFGHIJKLMNOPQRS',N'ABCD',N'cpe:32.7',N'ABCDEFGHIJKLMNOPQRSTUVWXYZABC',N'ABCDEFGHIJK',N'cpe:2.0',N'ABCDEFGHIJKLMNOPQRSTUVWXY',N'ABCDEFGHIJKL',N'cpe:/0:)::j',N'ABCDEFGHIJKLMN',N'ABCDEFGHIJKLMN',N'cpe:580308.9::',N'ABCDEFGHIJKLMNOPQRST',N'ABCDEFGHIJKLMNOPQRST',N'cpe:9.9-u:',N'ABCDE',N'ABCD',N'cpe:9.0::',N'ABCDEFGHIJKLMNOPQRSTUVWXYZ',N'ABCDEFGHIJKLMNOPQRSTUVWX',N'cpe:1.6{:_::::',N'ABCDEFGHIJKLMNOPQRSTU',N'ABCDEFGHIJKLMNO',N'cpe:0.0G-/',N'ABCDEFGHIJKLMNOPQRSTUVWXY',N'ABCDEFGHIJKLMN',N'cpe:5583.0:::',N'ABCDEFGHIJKLMNOPQRSTUVW',N'ABCDEFGHIJKL',N'cpe:20.1:5:)9pu',N'ABCDEFG',N'ABCDEFGHIJKL',N'cpe:/:XsNC:~',N'ABCDEFGHIJKLMNO',N'ABCDEFGHIJKLMNOP',N'cpe:/',N'ABCDEFGHIJKLM',N'ABCDEFGHIJKLMNOPQRST',N'cpe:86.7I:::*$s',N'ABCDEFGHIJKLMN',N'ABCDEFGHIJKLMNOPQRSTUVWXYZA',N'cpe:/i',N'ABCDEFGHIJKLMNOPQRSTUVWXYZABC',N'ABCDEFGHIJKLM',N'cpe:/o:e',N'ABCDEFGHIJKLMNOPQRSTUVWXYZA',N'ABCDE',N'cpe:707329.5q',N'ABCDEFGHIJKLMNOPQR',N'ABCDEFGHIJKLMNOPQRST',N'cpe:2.71k',N'ABCDEFGHIJKLMNOPQRSTU',N'ABCDEFGHIJKLMNOPQRSTUVWXY',N'cpe:/e:''%Y>:',N'ABCD',N'ABCDEFGHIJKLMNOPQRSTUVWXYZAB',N'cpe:3.2U',N'ABCDEFGHIJKLMN',N'ABCDEFGHIJKLMNOPQR',N'cpe:/DTD',N'ABCDEFGHIJKLMNOPQRSTUVWXYZA',N'ABCDEFGHIJKLMNOPQRSTUVWXYZ',N'cpe:/::L',N'ABCDEFGHIJ',N'ABCDEFGHIJKLMNOPQRS',N'cpe:/io''+dC:',N'ABCDEFGHIJKLMNOPQRSTUVWXYZ',N'ABCD',N'cpe:/:[4v::',N'ABCDEFGHIJKLMNOPQRSTUV',N'ABCDEFGHIJKL',N'cpe:8.8:',N'ABCDEFGHIJ',N'ABCD',N'cpe:4.4*',N'ABCDEFGHIJKLMNOPQRSTUVWXYZ',N'ABCDEFGHIJKLMN',N'cpe:/d]',N'ABCDEFGHIJKLMN',N'ABCDEFGH',N'cpe:/gR:-68::',N'ABCD',N'ABCDEFGHIJKLMNOPQRSTUVWXYZABC',N'cpe:/:',N'ABCDEFGHIJKLMNOPQRSTUVWXY',N'ABCD',N'cpe:/.',N'ABCDEFGHIJKLMNOPQ',N'ABCDEFGHIJKLMNOPQRSTUVWXY',N'cpe:/',N'ABCDEFGHIJKLMNOPQRSTUVWX',N'ABCDEFGHIJKLMNOPQRSTU',N'cpe:701.2''B:Pe',N'ABCDEFGHIJKLMNOPQ',N'ABCDEFGHIJKLMNOPQ',N'cpe:6.6?/',N'ABCDEFGHIJKL',N'ABCDEFGHIJKLMNOPQRSTUVWXYZAB',N'cpe:/1Ed:',N'ABCDEFGHI',N'ABCDEFGHIJKL',N'ABCDEFGHIJKLMNOPQRS',N'ABCDEFGHIJKLMNOPQRSTUVWXYZA',N'ABCDEFGHIJKLMNOPQRST',N'optional_component_of',N'ABCDEFGHIJKLMNO',N'ABCDEFGHIJKLMNOPQRSTUVW',N'cpe:91.4M',700,NULL,N'ABCDEFGHIJKLMNOPQRSTU',N'ABCDEFGHIJKLMNOPQRSTUVWXY',N'CVE-0886-7577',N'CWE-7',N'ABCDE',N'ABCDEFGHIJKLMNOPQR',N'ABCDE',N'ABCDEFGHIJKLMNOPQRSTUVWXYZA',N'other',N'not_contacted',N'ABCDEFGHIJKLMNOPQRSTUVWXYZ',N'other',N'ABCDEFGHIJKLMNOPQRSTUVWX',N'ABCDEFGHIJKLMNOP',N'ABCDEFGHIJKLMNOPQRST',N'ABCDEFGHIJKLMNO',N'ABCDEFGHIJKLMNOPQRSTUVWXYZAB',N'ABCDEFG',N'ABCDEFGHIJKLMNOP',N'ABCDE',N'ABCDEFGHIJKLMNO',N'ABCDEFGHIJKLMNOPQ',N'ABCDEFGHIJKLMNOPQR',N'ABCDEFGHI',N'ABCDEFGHIJKL',N'external',N'ABCDEFGH',N'ABCDEFGHI',N'none_available',N'ABCDEFGH',N'ABCDEFGHIJKLMNOPQRSTU',N'ABCDEFGHIJKLMNOPQRST',N'ABCDEFGHIJKLMNOPQRSTUVWXYZ',N'parent',N'ABCDEFGHIJKLMNOPQRS',N'ABCDEFGHIJKL',N'ABCDEFGHIJKLMNOPQ',N'impact',N'ABCDEFGHIJKLMNOPQRSTUVWXY',N'ABCDEFGH',N'ABCDEFGHIJKLMNOPQRSTUVW',N'ABCDEFGHI');
